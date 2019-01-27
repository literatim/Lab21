using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Lab21.Models;

namespace Lab21.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonContext")
        {
        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}