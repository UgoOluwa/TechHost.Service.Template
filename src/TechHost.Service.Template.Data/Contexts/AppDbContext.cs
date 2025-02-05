using Microsoft.EntityFrameworkCore;
using TechHost.Service.Template.Model.Entities;

namespace TechHost.Service.Template.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Database=fastapi;Username=postgres;Password=admin;");
    }

    public DbSet<WeatherForecast> WeatherForcasts { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherForecast>().ToTable("WeatherForcasts");
        modelBuilder.Entity<WeatherForecast>().HasKey(w => w.Id);

    }
}
