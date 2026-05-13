using _1500_m_race_simulation.Data.Configurations;
using _1500_m_race_simulation.Models;
using Microsoft.EntityFrameworkCore;

namespace _1500_m_race_simulation.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tournament> Tournaments => Set<Tournament>();
        public DbSet<Race> Races => Set<Race>();
        public DbSet<Runner> Runners => Set<Runner>();
        public DbSet<RaceEntry> RaceEntries => Set<RaceEntry>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // When EF builds the model, it uses this configuration to map the Runner entity
            // and define its database behavior (including seeding initial data via migrations).
            modelBuilder.ApplyConfiguration(new RunnerConfiguration());
        }
    }
}