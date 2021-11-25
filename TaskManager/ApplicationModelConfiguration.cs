using System.Data.Entity;
using TaskManager.Models;

namespace TaskManager
{
    public class ApplicationModelConfiguration
    {

        public static void Configure(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Category>();
            modelBuilder.Entity<Articles>();
        }





    }
}
