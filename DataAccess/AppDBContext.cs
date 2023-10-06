using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess;

public class AppDBContext : DbContext
{
    public AppDBContext() { }
    public AppDBContext(DbContextOptions options) : base(options) { }

    #region DB sets
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AnimalInformation> AnimalInformations { get; set; }
    public DbSet<Area> Areas { get; set; }
    public DbSet<Cage> Cages { get; set; }
    public DbSet<CageHistory> CageHistories { get; set; }
    public DbSet<Diet> Diets { get; set; }
    public DbSet<DietDetail> DietDetails { get; set; }
    public DbSet<FeedHistory> FeedHistories { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Species> Species { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<TicketOrder> TicketOrders { get; set; }
    public DbSet<TicketType> TicketTypes { get; set; }
    public DbSet<TrainingDetail> TrainingDetails { get; set; }
    #endregion

    // Connect DB
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionStrings());
        }
    }
    private string GetConnectionStrings()
    {
        IConfiguration config = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
        return config["ConnectionStrings:DefaultDB"]!;
    }

    // Get configurations from fluent api
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());        
    }

}
