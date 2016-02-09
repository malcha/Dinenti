namespace Data
{
    using Commons.Entities;
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Linq;

    public partial interface IDataContext 
    {
        int SaveChanges();
        IDataContext Add(object entity);
        IDataContext Update(object entity);
        IDataContext Delete(object entity);
        IDataContext Detach(object entity);
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

    }
    //TODO Autofact
        //public class DataContext : DbContext,IDataContext
    public class DataContext : DbContext
    {
        public DataContext(DbConnection connection)
            : base(connection, true) { }

        public DataContext()
            : base("DataContext") { }

        #region DbSet
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Clouth> Clouths { get; set; }
        #endregion
        //// Your context has been configured to use a 'DataContext' connection string from your application's 
        //// configuration file (App.config or Web.config). By default, this connection string targets the 
        //// 'Data.DataContext' database on your LocalDb instance. 
        //// 
        //// If you wish to target a different database and/or database provider, modify the 'DataContext' 
        //// connection string in the application configuration file.
        //public DataContext()
        //    : base("name=DataContext")
        //{
        //}

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}