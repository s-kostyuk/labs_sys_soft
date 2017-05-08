using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using lab6_v8.Model;

/*****************************************************************************/

namespace lab6_v8
{
    public class Controller
    {

        /*-------------------------------------------------------------------*/

		private DataSet libraryData;

		private DataTable BooksTable;
		private DataTable AuthorsTable;
		private DataTable PublishersTable;

		private List<Book> Books;
		private List<Author> Authors;
		private List<Publisher> Publishers;

        public BindingSource BooksBinding { get; private set; }
        public BindingSource AuthorsBinding { get; private set; }
        public BindingSource PublishersBinding { get; private set; }

        /*-------------------------------------------------------------------*/

        public int BooksByAuthor(string authorName)
		{
			return 0;//Books.Count(item => item.AuthorName == authorName);
        }

        /*-------------------------------------------------------------------*/

        public int BooksByAuthor(Author author)
        {
			return 0;//return Books.Count(item => item.Author == author);
        }

        /*-------------------------------------------------------------------*/

        public int BooksByPublisher(string publisherName)
        {
			return 0;//return Books.Count(item => item.PublisherName == publisherName);
        }

        /*-------------------------------------------------------------------*/

        public int BooksByPublisher(Publisher publisher)
        {
			return 0;//return Books.Count(item => item.Publisher == publisher);
        }

        /*-------------------------------------------------------------------*/

        public Controller()
        {
			libraryData = new DataSet ("LibraryData");

			AuthorsTable = new DataTable ("Authors");
			DataColumn authors_id = new DataColumn(), authors_name = new DataColumn();

			authors_id.AutoIncrement = true;
			authors_id.Unique = true;
			authors_id.DataType = System.Type.GetType("System.Int32");
			authors_id.ColumnName = "id";
			authors_id.ReadOnly = true;
			AuthorsTable.Columns.Add (authors_id);

			authors_name.DataType = System.Type.GetType("System.String");
			authors_name.ColumnName = "name";
			AuthorsTable.Columns.Add (authors_name);

			libraryData.Tables.Add (AuthorsTable);


			PublishersTable = new DataTable ("Publishers");
			DataColumn publishers_id = new DataColumn(), publishers_name = new DataColumn();

			publishers_id.AutoIncrement = true;
			publishers_id.Unique = true;
			publishers_id.DataType = System.Type.GetType("System.Int32");
			publishers_id.ColumnName = "id";
			publishers_id.ReadOnly = true;
			PublishersTable.Columns.Add (publishers_id);

			publishers_name.DataType = System.Type.GetType("System.String");
			publishers_name.ColumnName = "name";
			PublishersTable.Columns.Add (publishers_name);

			libraryData.Tables.Add (PublishersTable);



			BooksTable = new DataTable ("Books");
			DataColumn books_id = 
				new DataColumn()
				, books_author = new DataColumn()
				, books_title = new DataColumn()
				, books_publisher = new DataColumn()
				, books_year = new DataColumn();

			books_id.AutoIncrement = true;
			books_id.Unique = true;
			books_id.DataType = System.Type.GetType("System.Int32");
			books_id.ColumnName = "id";
			books_id.ReadOnly = true;
			BooksTable.Columns.Add (books_id);

			books_author.DataType = System.Type.GetType("System.Int32");
			books_author.ColumnName = "author_id";
			BooksTable.Columns.Add (books_author);

			books_title.DataType = System.Type.GetType("System.String");
			books_title.ColumnName = "title";
			BooksTable.Columns.Add (books_title);

			books_publisher.DataType = System.Type.GetType("System.Int32");
			books_publisher.ColumnName = "publisher_id";
			BooksTable.Columns.Add (books_publisher);

			books_year.DataType = System.Type.GetType ("System.Int16");
			books_year.ColumnName = "year";
			BooksTable.Columns.Add (books_year);

			DataColumn[] BooksPrimaryKeyColumns = new DataColumn[1];
			BooksPrimaryKeyColumns[0] = BooksTable.Columns["id"];
			BooksTable.PrimaryKey = BooksPrimaryKeyColumns;

			libraryData.Tables.Add (BooksTable);

			DataColumn parentColumn = 
				libraryData.Tables["Authors"].Columns["id"];
			DataColumn childColumn = 
				libraryData.Tables["Books"].Columns["author_id"];
			DataRelation relation = new 
				DataRelation("authors2books", parentColumn, childColumn);
			libraryData.Tables["Books"].ParentRelations.Add(relation);

			DataColumn parentColumn2 = 
				libraryData.Tables["Publishers"].Columns["id"];
			DataColumn childColumn2 = 
				libraryData.Tables["Books"].Columns["publisher_id"];
			DataRelation relation2 = new 
				DataRelation("publishers2books", parentColumn2, childColumn2);
			libraryData.Tables["Books"].ParentRelations.Add(relation2);


            Books = new List<Book>();
            Authors = new List<Author>();
            Publishers = new List<Publisher>();

            BooksBinding = new BindingSource();
            AuthorsBinding = new BindingSource();
            PublishersBinding = new BindingSource();

            BooksBinding.DataSource = BooksTable;
            AuthorsBinding.DataSource = AuthorsTable;
            PublishersBinding.DataSource = PublishersTable;

        }

        /*-------------------------------------------------------------------*/

        public void AddSampleData()
        {
			

            Author ford = new Author("Henry Ford");
            Author munroe = new Author("Randall Munroe");
            Author donavan_kernigan = new Author("Alan A. A. Donovan, Brian W. Kernighan");
            Author rockchild = new Author("Marc J. Rochkind");

            Publisher createSpace = new Publisher("CreateSpace Independent Publishing Platform");
            Publisher hmh = new Publisher("Houghton Mifflin Harcourt");
            Publisher aw = new Publisher("Addison-Wesley Professional");

            
            Authors.Add(ford);
            Authors.Add(munroe);
            Authors.Add(donavan_kernigan);
            Authors.Add(rockchild);
            

            
            Publishers.Add(createSpace);
            Publishers.Add(hmh);
            Publishers.Add(aw);
            

            
            Books.Add(new Book(ford, "My Life and Work", createSpace, 2013));
            Books.Add(new Book(munroe, "What If?: Serious Scientific Answers to Absurd Hypothetical Questions", hmh, 2014));
            Books.Add(new Book(donavan_kernigan, "The Go Programming Language", aw, 2015));
            Books.Add(new Book(rockchild, "Advanced UNIX Programming", aw, 2004));
            
			foreach (Author item in Authors) {
				DataRow row = AuthorsTable.NewRow();
				row["name"] = item.Name;
				AuthorsTable.Rows.Add(row);
			}

			foreach (Publisher item in Publishers) {
				DataRow row = PublishersTable.NewRow();
				row["name"] = item.Name;
				PublishersTable.Rows.Add(row);
			}

			foreach (Book item in Books) {
				DataRow row = BooksTable.NewRow();

				row["title"] = item.Title;

				row["author_id"] = AuthorsTable
					.AsEnumerable() // Convert DataTable to Enumerable to execute LINQ requests
					.Where(r => r.Field<string>("name") == item.AuthorName) // find rows with specified AuthorName
					.First() // get the first (and must be only) row in result
					["id"]; // get the id of Author with specified AuthorName
				
				row["publisher_id"] = PublishersTable
					.AsEnumerable()
					.Where(r => r.Field<string>("name") == item.PublisherName)
					.First()
					["id"];
				
				row ["year"] = item.Year;

				BooksTable.Rows.Add(row);
			}



        }

        /*-------------------------------------------------------------------*/

    }
}

/*****************************************************************************/
