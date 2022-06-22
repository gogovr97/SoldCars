namespace SoldCars.Database
{
    using Models;

    using Microsoft.EntityFrameworkCore;
    public class SoldCarsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if(optionsBuilder.IsConfigured == false)
            {
                string connectionString = "Server=DESKTOP-ATI79NK\\SQLEXPRESS;Database=SoldCarsDb;Integrated security=true;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Note>()
                .HasOne(t => t.User)
                .WithMany(u => u.Notes)
                .HasForeignKey(t => t.UserId);

            modelBuilder
                .Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique(true);
        }
    }
}
