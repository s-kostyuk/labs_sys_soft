using lab6_v8;
using lab6_v8.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        /*-------------------------------------------------------------------*/

        private BooksDataGridUpdater updater;
        private BindingRepoWrapper repo;

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
            
        }

        /*-------------------------------------------------------------------*/

        private void buttonPublishersMenu_Click(object sender, EventArgs e)
        {
            
        }

        /*-------------------------------------------------------------------*/
    }
}
