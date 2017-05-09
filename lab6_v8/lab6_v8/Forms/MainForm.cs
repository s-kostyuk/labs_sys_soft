using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab6_v8.Model;

/*****************************************************************************/

namespace lab6_v8.Forms
{
    public partial class MainForm : Form
    {

        Controller controller;

        /*-------------------------------------------------------------------*/

        public MainForm(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        /*-------------------------------------------------------------------*/

        public void ImportBooks()
        {
            foreach (Book book in controller.BooksBinding)
            {
                this.dataGridViewBooks.Rows.Add(
                    new String[] { book.AuthorName, book.Title, book.PublisherName, book.Year.ToString() }
                );
            }
        }

        /*-------------------------------------------------------------------*/

        private bool EditBook(DataGridViewRow _bookRow)
        {
            EditBookDialog dialog = new EditBookDialog(controller, _bookRow);

            return dialog.ShowDialog() == DialogResult.OK;
        }

        /*-------------------------------------------------------------------*/

        public void AddNewBook()
        {
            int newRowIndex = dataGridViewBooks.Rows.Add();
            DataGridViewRow newRow = dataGridViewBooks.Rows[newRowIndex];

            bool isAdded = EditBook(newRow);

            if (isAdded)
            {
                //dataGridViewBooks.Rows.Add(newRow);
            }
            else
            {
                dataGridViewBooks.Rows.Remove(newRow);
                newRow.Dispose();
            }
            
        }

        /*-------------------------------------------------------------------*/

        public void EditCurrentBook()
        {
            var row = this.dataGridViewBooks.CurrentRow;

            if (row != null)
            {
                EditBook(row);
            }
        }

        /*-------------------------------------------------------------------*/

        public void RemoveCurrentBook()
        {
            var row = this.dataGridViewBooks.CurrentRow;

            if (row != null)
            {
                this.dataGridViewBooks.Rows.Remove(row);
            }
        }

        /*-------------------------------------------------------------------*/

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddNewBook();
        }

        /*-------------------------------------------------------------------*/

        private void buttonModifyBook_Click(object sender, EventArgs e)
        {
            EditCurrentBook();
        }

        /*-------------------------------------------------------------------*/

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            RemoveCurrentBook();
        }

        /*-------------------------------------------------------------------*/

    }
}

/*****************************************************************************/
