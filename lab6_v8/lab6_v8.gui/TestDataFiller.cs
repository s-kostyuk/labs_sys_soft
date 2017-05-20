using lab6_v8.library;
using lab6_v8.library.Model;

/*****************************************************************************/

namespace lab6_v8.gui
{
    public class TestDataFiller
    {
        /*-------------------------------------------------------------------*/

        public void FillTestData(BindingRepoWrapper repo)
        {
            this.FillAuthors(repo);
            this.FillPublishers(repo);
            this.FillBooks(repo);
        }

        /*-------------------------------------------------------------------*/

        private void FillAuthors(BindingRepoWrapper repo)
        {
            repo.Authors.Add(ford);
            repo.Authors.Add(munroe);
            repo.Authors.Add(donavan_kernigan);
            repo.Authors.Add(rockchild);
            repo.Authors.Add(evans);
        }

        /*-------------------------------------------------------------------*/

        private void FillPublishers(BindingRepoWrapper repo)
        {
            repo.Publishers.Add(createSpace);
            repo.Publishers.Add(hmh);
            repo.Publishers.Add(aw);
        }

        /*-------------------------------------------------------------------*/

        private void FillBooks(BindingRepoWrapper repo)
        {
            repo.Books.Add(new Book(ford, "My Life and Work", createSpace, 2013));
            repo.Books.Add(new Book(munroe, "What If?: Serious Scientific Answers to Absurd Hypothetical Questions", hmh, 2014));
            repo.Books.Add(new Book(donavan_kernigan, "The Go Programming Language", aw, 2015));
            repo.Books.Add(new Book(rockchild, "Advanced UNIX Programming", aw, 2004));
            repo.Books.Add(new Book(evans, "Domain-Driven Design: Tackling Complexity in the Heart of Software", aw, 2003));
        }

        /*-------------------------------------------------------------------*/

        private Author ford = new Author("Henry Ford");
        private Author munroe = new Author("Randall Munroe");
        private Author donavan_kernigan = new Author("Alan A. A. Donovan, Brian W. Kernighan");
        private Author rockchild = new Author("Marc J. Rochkind");
        private Author evans = new Author("Eric Evans");

        private Publisher createSpace = new Publisher("CreateSpace Independent Publishing Platform");
        private Publisher hmh = new Publisher("Houghton Mifflin Harcourt");
        private Publisher aw = new Publisher("Addison-Wesley Professional");

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
