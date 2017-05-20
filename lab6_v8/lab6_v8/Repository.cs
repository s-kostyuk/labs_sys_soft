using lab6_v8.Model;

using System.Collections.Generic;

/*****************************************************************************/

namespace lab6_v8
{
    public class Repository
    {
        /*-------------------------------------------------------------------*/

        public IList<Author> Authors
        {
            get { return m_authors; }
        }

        /*-------------------------------------------------------------------*/

        public IList<Publisher> Publishers
        {
            get { return m_publishers; }
        }

        /*-------------------------------------------------------------------*/

        public IList<Book> Books
        {
            get { return m_books; }
        }

        /*-------------------------------------------------------------------*/

        public Repository()
        {
            m_authors = new List<Author>();
            m_publishers = new List<Publisher>();
            m_books = new List<Book>();
        }

        /*-------------------------------------------------------------------*/

        public void FillTestData()
        {
            Author ford = new Author("Henry Ford");
            Author munroe = new Author("Randall Munroe");
            Author donavan_kernigan = new Author("Alan A. A. Donovan, Brian W. Kernighan");
            Author rockchild = new Author("Marc J. Rochkind");
            Author evans = new Author("Eric Evans");

            Publisher createSpace = new Publisher("CreateSpace Independent Publishing Platform");
            Publisher hmh = new Publisher("Houghton Mifflin Harcourt");
            Publisher aw = new Publisher("Addison-Wesley Professional");

            //AuthorsBinding.SuspendBinding();
            Authors.Add(ford);
            Authors.Add(munroe);
            Authors.Add(donavan_kernigan);
            Authors.Add(rockchild);
            Authors.Add(evans);
            //AuthorsBinding.ResumeBinding();

            Publishers.Add(createSpace);
            Publishers.Add(hmh);
            Publishers.Add(aw);
            
            Books.Add(new Book(ford, "My Life and Work", createSpace, 2013));
            Books.Add(new Book(munroe, "What If?: Serious Scientific Answers to Absurd Hypothetical Questions", hmh, 2014));
            Books.Add(new Book(donavan_kernigan, "The Go Programming Language", aw, 2015));
            Books.Add(new Book(rockchild, "Advanced UNIX Programming", aw, 2004));
            Books.Add(new Book(evans, "Domain-Driven Design: Tackling Complexity in the Heart of Software", aw, 2003));
        }

        /*-------------------------------------------------------------------*/

        private List<Author> m_authors;
        private List<Publisher> m_publishers;
        private List<Book> m_books;
        
        /*-------------------------------------------------------------------*/
    }
}
