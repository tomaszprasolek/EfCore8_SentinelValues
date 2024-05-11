using Microsoft.EntityFrameworkCore;

namespace EfCore8_SentinelValues.Database;

internal class MyContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseName = "SentinelValues";
        optionsBuilder.UseSqlServer($"Server=localhost,1433;Database={databaseName};User Id=sa;Password=Password123#;MultipleActiveResultSets=true;Encrypt=false");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Customer>()
            .Property(x => x.Id);

        modelBuilder.Entity<Customer>()
            .Property(x => x.Name)
            .IsRequired();

        modelBuilder.Entity<Customer>()
            .Property(x => x.Status)
            .IsRequired()
            .HasDefaultValue(Status.New);

        modelBuilder.Entity<Customer>()
            .Property(x => x.Points)
            .IsRequired()
            .HasDefaultValue(10);
            //.HasSentinel(0);

        modelBuilder.Entity<Customer>()
            .Property(x => x.Created)
            .IsRequired()
            .HasDefaultValue(DateTime.UtcNow);
    }
}