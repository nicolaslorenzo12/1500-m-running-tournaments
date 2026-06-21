using RunningRaceSimulation.Data;
using RunningRaceSimulation.Models;
using RunningRaceSimulation.Repositories.Interfaces;

namespace RunningRaceSimulation.Repositories
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