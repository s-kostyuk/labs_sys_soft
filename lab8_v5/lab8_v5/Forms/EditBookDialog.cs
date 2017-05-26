using lab8_v5;
using lab8_v5.Model;

using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace lab8_v5.gui.Forms
{
    public partial class EditBookDialog : Form
    {
        /*-------------------------------------------------------------------*/

        public EditBookDialog(BindingRepoWrapper repo, int book_index)
        {
            this.repo = repo;
            this.book_index = book_index;

            InitializeComponent();

            this.comboBoxAuthor.DataSource = repo.Authors;
            this.comboBoxAuthor.DisplayMember = "Name";

            this.comboBoxPublisher.DataSource = repo.Publishers;
            this.comboBoxPublisher.DisplayMember = "Name";

            if (book_index < 0) {
                this.curr_book = new Book(Guid.NewGuid());
            }

            else {
                this.curr_book = (Book)repo.Books[book_index];
                this.comboBoxAuthor.SelectedItem = curr_book.Author;
                this.textBoxTitle.Text = curr_book.Title;
                this.comboBoxPublisher.SelectedItem = curr_book.Publisher;
                this.numericUpDownYear.Value = curr_book.Year;
            }
        }

        /*-------------------------------------------------------------------*/

        private BindingRepoWrapper repo;
        private int book_index;
        private Book curr_book;

        /*-------------------------------------------------------------------*/

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.curr_book.Author = (Author)this.comboBoxAuthor.SelectedItem;
            this.curr_book.Title = this.textBoxTitle.Text;
            this.curr_book.Publisher = (Publisher)this.comboBoxPublisher.SelectedItem;
            this.curr_book.Year = (short)this.numericUpDownYear.Value;
            
            if (book_index < 0)
            {
                repo.Books.Add(this.curr_book);
            }

            this.DialogResult = DialogResult.OK;
        }

        /*-------------------------------------------------------------------*/

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
