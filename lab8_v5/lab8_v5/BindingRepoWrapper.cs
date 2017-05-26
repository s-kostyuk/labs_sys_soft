using System.Windows.Forms;

/*****************************************************************************/

namespace lab8_v5
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

        private void Rebind()
        {
            this.m_bs_authors.DataSource = m_source_repo.Authors;
            this.m_bs_publishers.DataSource = m_source_repo.Publishers;
            this.m_bs_books.DataSource = m_source_repo.Books;
        }

        /*-------------------------------------------------------------------*/

        public void SaveToDB()
        {
            using (var context = new LibraryDbContext()) {
                context.Authors.AddRange(this.m_source_repo.Authors);
                context.Publishers.AddRange(this.m_source_repo.Publishers);
                context.Books.AddRange(this.m_source_repo.Books);

                context.SaveChanges();
            }
        }

        /*-------------------------------------------------------------------*/

        public void LoadFromDB()
        {
            using (var context = new LibraryDbContext())
            {
                this.Books.Clear();
                this.Authors.Clear();
                this.Publishers.Clear();
                
                foreach (var item in context.Authors)
                {
                    this.Authors.Add(item);
                }

                foreach (var item in context.Publishers)
                {
                    this.Publishers.Add(item);
                }

                foreach (var item in context.Books)
                {
                    this.Books.Add(item);
                }
            }
        }

        /*-------------------------------------------------------------------*/

        private Repository m_source_repo;

        private BindingSource m_bs_authors = new BindingSource();
        private BindingSource m_bs_publishers = new BindingSource();
        private BindingSource m_bs_books = new BindingSource();
        
        /*-------------------------------------------------------------------*/
    }
}
