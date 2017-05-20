﻿/*****************************************************************************/

namespace lab6_v8.library.Model
{
    /// <summary>
    /// Каждая книга характеризуется автором (выбирается из списка),
    /// названием, издательством(выбирается из списка), годом издания.
    /// </summary>
    public class Book
    {
        /*-------------------------------------------------------------------*/

		public Author Author { get; set; }

		/*-------------------------------------------------------------------*/

        public string Title { get; set; }

		/*-------------------------------------------------------------------*/
        
        public Publisher Publisher { get; set; }
        
		/*-------------------------------------------------------------------*/

        public short Year { get; set; }

		/*-------------------------------------------------------------------*/

		public Book() {}

		/*-------------------------------------------------------------------*/

		public Book(Author author, string title, Publisher publisher, short year) {

			this.Author = author;
			this.Title = title;
			this.Publisher = publisher;
			this.Year = year;

		}

        /*-------------------------------------------------------------------*/


    }
}

/*****************************************************************************/