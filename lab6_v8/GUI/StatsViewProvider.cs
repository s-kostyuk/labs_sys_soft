using lab6_v8;
using lab6_v8.Model;

using System.Collections;
using System.Linq;

/*****************************************************************************/

namespace GUI
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
