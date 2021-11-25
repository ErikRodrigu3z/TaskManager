using SQLite.CodeFirst;
using System.Data.Entity;
using TaskManager.Models;

namespace TaskManager
{
    public class ApplicationDbInitializer : SqliteDropCreateDatabaseWhenModelChanges<ApplicationDbContext>
    {
        public ApplicationDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder, typeof(CustomHistory))
        {

        }

        protected override void Seed(ApplicationDbContext context)
        {
            // Here you can seed your core data if you have any.
        }

    }
}
