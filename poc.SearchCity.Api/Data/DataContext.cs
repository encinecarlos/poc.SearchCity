using Microsoft.EntityFrameworkCore;
using poc.SearchCity.Api.Data.Entities;

namespace poc.SearchCity.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("cidades", "public");
        }
    }
}
