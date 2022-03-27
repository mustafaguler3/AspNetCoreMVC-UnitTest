using Microsoft.EntityFrameworkCore;

namespace RealWorldUnitTest.Web.Models.Context
{
    public class UnitTestDbContext : DbContext
    {
        public UnitTestDbContext()
        {

        }

        public UnitTestDbContext(DbContextOptions<UnitTestDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A2ULF2L;database=UdemyUnitTestDb;integrated security=true");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
