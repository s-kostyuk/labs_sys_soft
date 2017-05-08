using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using lab6_v8.Model;

/*****************************************************************************/

namespace lab6_v8
{
    public class Controller
    {

        /*-------------------------------------------------------------------*/

        private List<Book> Books;
        private List<Author> Authors;
        private List<Publisher> Publishers;

        public BindingSource BooksBinding { get; private set; }
        public BindingSource AuthorsBinding { get; private set; }
        public BindingSource PublishersBinding { get; private set; }

        /*-------------------------------------------------------------------*/

		public int BooksByAuthor(string authorName) {
			return Books.Count(item => item.AuthorName == authorName);
		}

		/*-------------------------------------------------------------------*/

		public int BooksByAuthor(Author author) {
			return Books.Count (item => item.Author == author);
		}

		/*-------------------------------------------------------------------*/

		public int BooksByPublisher(string publisherName) {
			return Books.Count(item => item.PublisherName == publisherName);
		}

		/*-------------------------------------------------------------------*/

		public int BooksByPublisher(Publisher publisher) {
			return Books.Count(item => item.Publisher == publisher);
		}

		/*-------------------------------------------------------------------*/

        public Controller()
        {

            Books = new List<Book>();
            Authors = new List<Author>();
            Publishers = new List<Publisher>();

			BooksBinding = new BindingSource ();
			AuthorsBinding = new BindingSource ();
			PublishersBinding = new BindingSource ();



            BooksBinding.DataSource = Books;
            AuthorsBinding.DataSource = Authors;
            PublishersBinding.DataSource = Publishers;

        }

        /*-------------------------------------------------------------------*/

		public void AddSampleData() {
			Author ford = new Author ("Henry Ford");
			Author munroe = new Author ("Randall Munroe");
			Author donavan_kernigan = new Author ("Alan A. A. Donovan, Brian W. Kernighan");
			Author rockchild = new Author ("Marc J. Rochkind");

			Publisher createSpace = new Publisher ("CreateSpace Independent Publishing Platform");
			Publisher hmh = new Publisher ("Houghton Mifflin Harcourt");
			Publisher aw = new Publisher ("Addison-Wesley Professional");

			Authors.Add (ford);
			Authors.Add (munroe);
			Authors.Add (donavan_kernigan);
			Authors.Add (rockchild);

			Publishers.Add (createSpace);
			Publishers.Add (hmh);
			Publishers.Add (aw);

			Books.Add(new Book(ford, "My Life and Work", createSpace, 2013));
			Books.Add(new Book(munroe, "What If?: Serious Scientific Answers to Absurd Hypothetical Questions", hmh, 2014));
			Books.Add(new Book(donavan_kernigan, "The Go Programming Language", aw, 2015));
			Books.Add(new Book(rockchild, "Advanced UNIX Programming", aw, 2004));
		}

		/*-------------------------------------------------------------------*/



    }
}

/*****************************************************************************/
