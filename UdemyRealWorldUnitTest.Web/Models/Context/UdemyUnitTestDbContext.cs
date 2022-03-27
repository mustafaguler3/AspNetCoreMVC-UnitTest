using Microsoft.EntityFrameworkCore;

namespace UdemyRealWorldUnitTest.Web.Models.Context
{
    public class UdemyUnitTestDbContext : DbContext
    {
        public UdemyUnitTestDbContext()
        {

        }

        public UdemyUnitTestDbContext(DbContextOptions<UdemyUnitTestDbContext> options):base(options)
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
