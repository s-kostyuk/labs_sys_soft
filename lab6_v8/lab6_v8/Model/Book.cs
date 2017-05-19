﻿using System;

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

		public Author Author { get; set; }

		/*-------------------------------------------------------------------*/

        public string Title { get; set; }

		/*-------------------------------------------------------------------*/
        
        public Publisher Publisher { get; set; }
        
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
