using HRP;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Food> Foods => Set<Food>();
    public DbSet<FoodBatch> FoodBatches => Set<FoodBatch>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=app.db");
    }
}