using System.Data.Common;
using System.Data.Entity;

namespace TaskManager
{
    // https://www.nuget.org/packages/SQLite.CodeFirst/
    // https://github.com/msallin/SQLiteCodeFirst


    public class ApplicationDbContext : DbContext
    {        

        public ApplicationDbContext()
        : base("TaskManagerDB") 
        {
            Configure();
        }

        public ApplicationDbContext(DbConnection connection, bool contextOwnsConnection)
             : base(connection, contextOwnsConnection)
        {
            Configure();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ApplicationModelConfiguration.Configure(modelBuilder);
            var initializer = new ApplicationDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }

        private void Configure()
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

    }
}
