using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSqlLocalDb;Database=Library_NPR321;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Role
            modelBuilder.Entity<RoleEntity>()
                .Property(r => r.Name)
                .HasMaxLength(20)
                .IsRequired();

            // User
            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Email)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<UserEntity>()
                .Property(u => u.Password)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<UserEntity>()
                .Property(u => u.UserName)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<UserEntity>()
                .Property(u => u.PhoneNumber)
                .HasMaxLength(15);

            // References
            // one to many
            modelBuilder.Entity<UserEntity>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
