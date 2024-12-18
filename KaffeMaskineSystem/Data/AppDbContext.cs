using Microsoft.EntityFrameworkCore;
using KaffeMaskineSystem.Models;

namespace KaffeMaskineSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cleaning> Cleanings { get; set; }
        public DbSet<CoffeeMachine> CoffeeMachines { get; set; }
        public DbSet<Refill> Refills { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<MachineMaintenanceRecord> MachineMaintenanceRecords { get; set; }

        public DbSet<TrayEmptyingRecord> TrayEmptyingRecords { get; set; }

        public DbSet<TubeChange> TubeChanges { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
