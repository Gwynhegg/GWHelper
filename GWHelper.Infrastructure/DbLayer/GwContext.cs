using System.Data.Entity;
using GWHelper.Infrastructure.Models;

namespace GWHelper.Infrastructure.DbLayer
{
    public class GwContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
