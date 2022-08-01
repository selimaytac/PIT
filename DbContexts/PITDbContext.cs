using DTPersonalInfoTracker.Helpers;
using DTPersonalInfoTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DTPersonalInfoTracker.DbContexts;

public class PITDbContext : DbContext
{
    public DbSet<PersonelModel> Personels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(SettingsHelper.GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonelModel>().HasKey(p => p.RecordId);
    }
}