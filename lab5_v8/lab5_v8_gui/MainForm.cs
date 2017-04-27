using lab5_v8;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

/*****************************************************************************/

namespace lab5_v8_gui
{
    public partial class MainForm : Form
    {
        /*-------------------------------------------------------------------*/

        private SaveFileDialog saveDialog;
        private OpenFileDialog openDialog;
        private string sourceFile1;
        private string sourceFile2;

        /*-------------------------------------------------------------------*/

        private void SetFilterAndExtension(FileDialog dialog)
        {
            dialog.Filter = "Binary data (*.bin)|*.bin";
            dialog.AddExtension = true;
            dialog.DefaultExt = "bin";
        }

        /*-------------------------------------------------------------------*/

        private void SelectPathAndGenerateFile(string defautName = null)
        {
            saveDialog.FileName = defautName;

            string result_file;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                result_file = saveDialog.FileName;
                BinaryDoublesFileGenerator
                    .GenerateRandomSortedSequence(result_file, 0, 10, 1000);
            }
        }

        /*-------------------------------------------------------------------*/

        private void OpenFileAndUpdateListbox(
            ListBox listbox,
            ref string openedFile,
            string defaultName = null)
        {
            openDialog.FileName = defaultName;

            string file_to_open;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                file_to_open = openDialog.FileName;
                listbox.Items.Clear();

                IEnumerable<double> file_enum = 
                    new BinaryFileDoubleEnumerable(file_to_open);

                foreach (double item in file_enum)
                {
                    listbox.Items.Add(item);
                }

                openedFile = file_to_open;
            }
        }

        /*-------------------------------------------------------------------*/

        public MainForm()
        {
            InitializeComponent();

            saveDialog = new SaveFileDialog();
            SetFilterAndExtension(saveDialog);

            openDialog = new OpenFileDialog();
            SetFilterAndExtension(openDialog);
        }

        /*-------------------------------------------------------------------*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*-------------------------------------------------------------------*/

        private void buttonGenerateSource1_Click(object sender, EventArgs e)
        {
            SelectPathAndGenerateFile("source_file_1");
        }

        /*-------------------------------------------------------------------*/

        private void buttonGenerateSource2_Click(object sender, EventArgs e)
        {
            SelectPathAndGenerateFile("source_file_2");
        }

        /*-------------------------------------------------------------------*/

        private void buttonOpenSource1_Click(object sender, EventArgs e)
        {
            OpenFileAndUpdateListbox(listBoxSource1, ref sourceFile1, "source_file_1" );
        }

        /*-------------------------------------------------------------------*/

        private void buttonOpenSource2_Click(object sender, EventArgs e)
        {
            OpenFileAndUpdateListbox(listBoxSource2, ref sourceFile2, "source_file_2");
        }

        /*-------------------------------------------------------------------*/

        private void GenerateMergedFileAndPreview(string path)
        {
            IEnumerable<double> firstFileContent = 
                new BinaryFileDoubleEnumerable(sourceFile1);

            IEnumerable<double> secondFileContent = 
                new BinaryFileDoubleEnumerable(sourceFile2);

            IEnumerable<double> merged = SortedEnumerablesMerger<double>.Merge(
                firstFileContent,
                secondFileContent
            );

            Stream target = File.Open(path, FileMode.OpenOrCreate);
            BinaryWriter writer = new BinaryWriter(target);

            listBoxMerged.Items.Clear();

            foreach (double item in merged)
            {
                listBoxMerged.Items.Add(item);
                writer.Write(item);
            }

            writer.Close();
            writer.Dispose();

            target.Close();
            target.Dispose();
        }

        /*-------------------------------------------------------------------*/

        private void buttonGenerateMerged_Click(object sender, EventArgs e)
        {
            saveDialog.FileName = "merged_file";

            string result_file;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                result_file = saveDialog.FileName;
                GenerateMergedFileAndPreview(result_file);
            }
           
        }

        /*-------------------------------------------------------------------*/

    }
}
