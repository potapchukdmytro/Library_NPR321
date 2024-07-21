using Microsoft.EntityFrameworkCore;

namespace Library.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSqlLocalDb;Database=Library_NPR321;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
