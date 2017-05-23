using lab6_v8.library;

using System;
using System.Windows.Forms;
using System.IO;

/*****************************************************************************/

namespace lab6_v8.gui.Forms
{
    public partial class MainForm : Form
    {
        /*-------------------------------------------------------------------*/

        public MainForm(BindingRepoWrapper wrapper)
        {
            InitializeComponent();

            updater = new BooksDataGridUpdater
            (
            dataGridViewBooks, wrapper.Books
            );

            updater.UpdateDGV();

            repo = wrapper;
            provider = new StatsViewProvider(repo);

            saveDialog = new SaveFileDialog();
            SetFilterAndExtension(saveDialog);

            openDialog = new OpenFileDialog();
            SetFilterAndExtension(openDialog);
        }

        /*-------------------------------------------------------------------*/

        private BooksDataGridUpdater updater;
        private BindingRepoWrapper repo;
        private LibraryStatsForm lib_stats_form;
        private StatsViewProvider provider;
        private SaveFileDialog saveDialog;
        private OpenFileDialog openDialog;

        /*-------------------------------------------------------------------*/

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            DialogResult result = new EditBookDialog(repo, -1).ShowDialog();
        }

        /*-------------------------------------------------------------------*/

        private int GetBookIndex()
        {
            var row = this.dataGridViewBooks.CurrentRow;

            if (row == null)
            {
                return -1; // No rows available, no rows selected, no books selected
            }

            else
            {
                int id = (int)row.Cells["ID"].Value;

                return id;
            }
        }

        /*-------------------------------------------------------------------*/

        private void buttonModifyBook_Click(object sender, EventArgs e)
        {
            DialogResult result = new EditBookDialog(repo, GetBookIndex()).ShowDialog();

            if (result == DialogResult.OK)
            {
                this.repo.Books.ResetBindings(false);
            }
        }

        /*-------------------------------------------------------------------*/

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            int index = GetBookIndex();

            this.repo.Books.RemoveAt(index);
        }

        /*-------------------------------------------------------------------*/

        private void buttonAuthorsMenu_Click(object sender, EventArgs e)
        {
            EditCollectionDialog dialog = new EditCollectionDialog(this.repo.Authors);

            dialog.Text = "Edit Authors";

            DialogResult result = dialog.ShowDialog();
        }

        /*-------------------------------------------------------------------*/

        private void buttonPublishersMenu_Click(object sender, EventArgs e)
        {
            EditCollectionDialog dialog = new EditCollectionDialog(this.repo.Publishers);

            dialog.Text = "Edit Publishers";

            DialogResult result = dialog.ShowDialog();
        }

        /*-------------------------------------------------------------------*/

        private void buttonStats_Click(object sender, EventArgs e)
        {
            if (this.lib_stats_form == null || this.lib_stats_form.IsDisposed)
            {
                this.lib_stats_form = new LibraryStatsForm(provider);
                this.lib_stats_form.Show();
            }
            else
            {
                this.lib_stats_form.BringToFront();
            }
        }

        /*-------------------------------------------------------------------*/

        private void SetFilterAndExtension(FileDialog dialog)
        {
            dialog.Filter = "Json data (*.json)|*.json";
            dialog.AddExtension = true;
            dialog.DefaultExt = "json";
        }

        /*-------------------------------------------------------------------*/

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openDialog.FileName;

                StreamReader reader = new StreamReader(
                    File.Open(path, FileMode.Open)
                    );

                string source_data = reader.ReadToEnd();

                this.repo.Deserialize(source_data);

                reader.Dispose();
            }
        }

        /*-------------------------------------------------------------------*/

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveDialog.FileName;

                StreamWriter writer = new StreamWriter(
                    File.Open(path, FileMode.OpenOrCreate)
                    );

                writer.Write(repo.Serialize());

                writer.Dispose();
            }
        }

        /*-------------------------------------------------------------------*/
    }
}
