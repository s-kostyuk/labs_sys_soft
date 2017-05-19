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
        public MainForm(BindingRepoWrapper wrapper)
        {
            InitializeComponent();

            updater = new BooksDataGridUpdater
                (
                dataGridViewBooks, wrapper.Books
                );

            repo = wrapper;

            sample = GetSampleBook().GetEnumerator();

            // fill test data
            this.repo.Authors.Add(ford);
            this.repo.Authors.Add(munroe);
            this.repo.Authors.Add(donavan_kernigan);
            this.repo.Authors.Add(rockchild);
            this.repo.Authors.Add(evans);

            this.repo.Publishers.Add(createSpace);
            this.repo.Publishers.Add(hmh);
            this.repo.Publishers.Add(aw);

            this.repo.Books.Add(new Book(ford, "My Life and Work", createSpace, 2013));
        }

        private BooksDataGridUpdater updater;
        private BindingRepoWrapper repo;
        
        private Author ford = new Author("Henry Ford");
        private Author munroe = new Author("Randall Munroe");
        private Author donavan_kernigan = new Author("Alan A. A. Donovan, Brian W. Kernighan");
        private Author rockchild = new Author("Marc J. Rochkind");
        private Author evans = new Author("Eric Evans");

        private Publisher createSpace = new Publisher("CreateSpace Independent Publishing Platform");
        private Publisher hmh = new Publisher("Houghton Mifflin Harcourt");
        private Publisher aw = new Publisher("Addison-Wesley Professional");

        private IEnumerator<Book> sample;

        public IEnumerable<Book> GetSampleBook()
        {
            yield return new Book(munroe, "What If?: Serious Scientific Answers to Absurd Hypothetical Questions", hmh, 2014);
            yield return new Book(donavan_kernigan, "The Go Programming Language", aw, 2015);
            yield return new Book(rockchild, "Advanced UNIX Programming", aw, 2004);
            yield return new Book(evans, "Domain-Driven Design: Tackling Complexity in the Heart of Software", aw, 2003);
            yield break;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            bool has_new = sample.MoveNext();

            if (has_new)
            {
                this.repo.Books.Add(sample.Current);
            }
            
            
            
        }

        private int GetBookIndex()
        {
            var row = this.dataGridViewBooks.CurrentRow;

            int id = (int)row.Cells["ID"].Value;

            return id;
        }

        private void buttonModifyBook_Click(object sender, EventArgs e)
        {
            DialogResult result = new EditBookDialog(repo, GetBookIndex()).ShowDialog();

            if (result != DialogResult.OK)
            {


                //book.Title = "CHANGED";

                this.repo.Books.ResetBindings(false);
            }
            
            
            
        }
    }
}
