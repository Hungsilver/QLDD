using Microsoft.EntityFrameworkCore;
using QLDD.Models;

namespace QLDD.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1-1 : user-per adddress
            modelBuilder.Entity<User>()
                .HasOne(u => u.PermanentAddress)
                .WithOne()
                .HasForeignKey<User>(u=>u.PermanentAddressID)
                .IsRequired(false);

            //1-1 : user-tem adddress
            modelBuilder.Entity<User>()
                .HasOne(u => u.TemporaryAddress)
                .WithOne()
                .HasForeignKey<User>(u => u.TemporaryAddressID)
                .IsRequired(false);
        }
    }
}
