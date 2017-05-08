using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

/*****************************************************************************/

namespace lab6_v8.Model
{
    /// <summary>
    /// Каждая книга характеризуется автором (выбирается из списка),
    /// названием, издательством(выбирается из списка), годом издания.
    /// </summary>
    public class Book
    {
        /*-------------------------------------------------------------------*/

		[Browsable(false)]
        public Author Author { get; set; }

		/*-------------------------------------------------------------------*/

		public string AuthorName
		{
			get
			{
				if (this.Author == null) {
					return null;
				} else {
					return Author.Name;
				}
			}
		}

		/*-------------------------------------------------------------------*/

        public string Title { get; set; }

		/*-------------------------------------------------------------------*/

		[Browsable(false)]
        public Publisher Publisher { get; set; }

		/*-------------------------------------------------------------------*/

		public string PublisherName
		{
			get
			{
				if (this.Publisher == null) {
					return null;
				} else {
					return Publisher.Name;
				}
			}
		}

		/*-------------------------------------------------------------------*/

        public Int16 Year { get; set; }

		/*-------------------------------------------------------------------*/

		public Book() {}

		/*-------------------------------------------------------------------*/

		public Book(Author author, string title, Publisher publisher, Int16 year) {

			this.Author = author;
			this.Title = title;
			this.Publisher = publisher;
			this.Year = year;

		}

        /*-------------------------------------------------------------------*/


    }
}

/*****************************************************************************/
