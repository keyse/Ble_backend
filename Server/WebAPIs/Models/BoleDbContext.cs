using System.Data.Entity;
using DomainModels;

namespace WebAPIs.Models
{
    public class BoleDbContext : DbContext
    {
        public DbSet<Transfere> Transferes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
