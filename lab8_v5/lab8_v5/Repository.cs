using lab8_v5.Model;

using System.Collections.Generic;

/*****************************************************************************/

namespace lab8_v5
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

        private List<Author> m_authors;
        private List<Publisher> m_publishers;
        private List<Book> m_books;
        
        /*-------------------------------------------------------------------*/
    }
}
