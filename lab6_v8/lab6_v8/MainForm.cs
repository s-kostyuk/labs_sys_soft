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

namespace lab6_v8
{
    public partial class MainForm : Form
    {
        
        /*-------------------------------------------------------------------*/

        public MainForm()
        {
            InitializeComponent();
        }

        /*-------------------------------------------------------------------*/

		public void ImportBooks (Controller _controller) {
			foreach (Book book in _controller.BooksBinding) {
				this.dataGridViewBooks.Rows.Add(
					new String[] { book.AuthorName, book.Title, book.PublisherName, book.Year.ToString() }
				);
			}
		}

		/*-------------------------------------------------------------------*/

    }
}

/*****************************************************************************/
