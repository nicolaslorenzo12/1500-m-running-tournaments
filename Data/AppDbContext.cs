using _1500_m_race_simulation.Models;
using Microsoft.EntityFrameworkCore;

namespace _1500_m_race_simulation.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tournament> Tournaments => Set<Tournament>();

        public DbSet<Race> Races => Set<Race>();

        public DbSet<Runner> Runners => Set<Runner>();

        public DbSet<RunnerResult> RunnerResults => Set<RunnerResult>();

        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}