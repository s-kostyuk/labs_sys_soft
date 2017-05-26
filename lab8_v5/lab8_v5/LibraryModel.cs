namespace lab8_v5
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using lab8_v5;

    public class LibraryModel : DbContext
    {
        // Контекст настроен для использования строки подключения "LibraryModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "lab8_v5.LibraryModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LibraryModel" 
        // в файле конфигурации приложения.
        public LibraryModel()
            : base("name=LibraryModel")
        {
            //Database.SetInitializer(
            //    new DropCreateDatabaseAlways<LibraryModel>()
            //);
        }



        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Model.Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configurations.BasicEntityConfiguration<Model.Author>());
        }
    }

    

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}