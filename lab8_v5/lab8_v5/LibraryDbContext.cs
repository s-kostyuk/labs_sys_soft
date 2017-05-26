using lab8_v5.Model;

using System;
using System.Data.Entity;
using System.Linq;

/*****************************************************************************/

namespace lab8_v5
{
    public class LibraryDbContext : DbContext
    {
        // Контекст настроен для использования строки подключения "LibraryDbContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "lab8_v5.LibraryDbContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LibraryDbContext" 
        // в файле конфигурации приложения.
        public LibraryDbContext()
            : base("name=LibraryDbContext")
        {
            Database.SetInitializer(
                new DropCreateDatabaseAlways<LibraryDbContext>()
            );
        }

        /*-------------------------------------------------------------------*/

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        /*-------------------------------------------------------------------*/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DbConfigurations.BasicEntityConfiguration<Author>());
        }

        /*-------------------------------------------------------------------*/
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}

/*****************************************************************************/
