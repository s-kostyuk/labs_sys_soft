using lab6_v8;

using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace GUI.Forms
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

            repo = wrapper;

            TestDataFiller tf = new TestDataFiller();
            tf.FillTestData(repo);

            provider = new StatsViewProvider(repo);

        }
        
        /*-------------------------------------------------------------------*/

        private BooksDataGridUpdater updater;
        private BindingRepoWrapper repo;
        private LibraryStatsForm lib_stats_form;
        private StatsViewProvider provider;

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
    }
}
