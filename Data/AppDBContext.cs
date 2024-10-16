using Microsoft.EntityFrameworkCore;
using QLDD.Models;

namespace QLDD.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<HistoryDocument> HistoryDocuments { get; set; }
        public DbSet<HouseHold> HouseHolds { get; set; }
        public DbSet<ProcessInfo> ProcessInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1-1 : user-per adddress
            modelBuilder.Entity<User>()
                .HasOne(u => u.PermanentAddress)
                .WithOne()
                .HasForeignKey<User>(u => u.PermanentAddressID)
                .IsRequired(false);

            //1-1 : user-tem adddress
            modelBuilder.Entity<User>()
                .HasOne(u => u.TemporaryAddress)
                .WithOne()
                .HasForeignKey<User>(u => u.TemporaryAddressID)
                .IsRequired(false);

            //n-1 household - user
            modelBuilder.Entity<User>()
                .HasOne(u => u.HouseHold)
                .WithMany(h => h.Users)
                .HasForeignKey(u => u.HouseHoldID)
                .IsRequired(false);

            //1-1: document - processInfo
            modelBuilder.Entity<Document>()
                .HasOne(d => d.ProcessInfo)
                .WithOne()
                .HasForeignKey<Document>(d => d.ProcessInfoID)
                .IsRequired(false);

            //1-n: document - history
            //modelBuilder.Entity<Document>()
            //    .HasMany(d => d.)
            //    .WithOne()
            //    .HasForeignKey<Document>(d => d.ProcessInfoID)
            //    .IsRequired(false);
        }
    }
}
