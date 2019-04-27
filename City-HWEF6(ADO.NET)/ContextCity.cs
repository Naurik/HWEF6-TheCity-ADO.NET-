namespace City_HWEF6_ADO.NET_
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextCity : DbContext
    {
        // Контекст настроен для использования строки подключения "ContextCity" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "City_HWEF6_ADO.NET_.ContextCity" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ContextCity" 
        // в файле конфигурации приложения.
        public ContextCity()
            : base("name=ContextCity")
        {
        }

        public DbSet<Cities> City { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}