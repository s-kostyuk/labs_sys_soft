using System.Windows.Forms;

/*****************************************************************************/

namespace lab6_v8.library
{
    public class BindingRepoWrapper
    {
        
        /*-------------------------------------------------------------------*/

        public BindingSource Authors {
            get { return m_bs_authors; }
        }

        /*-------------------------------------------------------------------*/

        public BindingSource Publishers
        {
            get { return m_bs_publishers; }
        }

        /*-------------------------------------------------------------------*/

        public BindingSource Books
        {
            get { return m_bs_books; }
        }

        /*-------------------------------------------------------------------*/

        public BindingRepoWrapper(Repository source_repo)
        {
            this.m_source_repo = source_repo;

            this.m_bs_authors.DataSource = m_source_repo.Authors;
            this.m_bs_publishers.DataSource = m_source_repo.Publishers;
            this.m_bs_books.DataSource = m_source_repo.Books;
        }

        /*-------------------------------------------------------------------*/

        private Repository m_source_repo;

        private BindingSource m_bs_authors = new BindingSource();
        private BindingSource m_bs_publishers = new BindingSource();
        private BindingSource m_bs_books = new BindingSource();
        
        /*-------------------------------------------------------------------*/
    }
}
