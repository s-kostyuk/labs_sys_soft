using lab6_v8.library;
using lab6_v8.library.Model;

using System.Collections;
using System.Linq;

/*****************************************************************************/

namespace lab6_v8.gui
{
    public class StatsViewProvider
    {
        /*-------------------------------------------------------------------*/

        public IList AuthorStats
        {
            get
            {
                return repo.Books.Cast<Book>()
                    .GroupBy(item => item.Author)
                    .Select(group => new { Name = group.Key.Name, Count = group.Count() })
                    .ToList();
            }
        }

        /*-------------------------------------------------------------------*/

        public IList PublisherStats
        {
            get
            {
                return repo.Books.Cast<Book>()
                    .GroupBy(item => item.Publisher)
                    .Select(group => new { Name = group.Key.Name, Count = group.Count() })
                    .ToList();
            }
        }

        /*-------------------------------------------------------------------*/

        public StatsViewProvider(BindingRepoWrapper repo)
        {
            this.repo = repo;
        }

        /*-------------------------------------------------------------------*/

        private BindingRepoWrapper repo;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
