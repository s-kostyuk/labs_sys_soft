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

/*****************************************************************************/

namespace GUI.Forms
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

            if (book_index >= 0)
            {
                Book curr_book = (Book)repo.Books[book_index];
                //this.comboBoxAuthor.SelectedValue = curr_book.Author;
                this.textBoxTitle.Text = curr_book.Title;
                //this.comboBoxPublisher.SelectedValue = curr_book.Publisher;
                this.numericUpDownYear.Value = curr_book.Year;
            }
        }

        /*-------------------------------------------------------------------*/

        private BindingRepoWrapper repo;
        private int book_index;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
