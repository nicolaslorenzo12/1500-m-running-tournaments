using _1500_m_race_simulation.Data;
using _1500_m_race_simulation.Models;
using _1500_m_race_simulation.Repositories.Interfaces;

namespace _1500_m_race_simulation.Repositories
{
    public class RunnerRepository : IRunnerRepository
    {
        private readonly AppDbContext _context;

        public RunnerRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Runner> GetAll()
        {
            return _context.Runners
                           .OrderBy(r => r.Ranking)
                           .ToList();
        }
    }
}