using Microsoft.EntityFrameworkCore;
using RunningRaceSimulation.Data;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Repositories.Interfaces;

namespace RunningRaceSimulation.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private readonly AppDbContext _context;

        public RaceRepository(AppDbContext context)
        {
            _context = context;
        }

        public Race GetById(int raceId)
        {
            return _context.Races
                .Include(r => r.Entries)
                    .ThenInclude(e => e.Runner)
                        .Single(r => r.Id == raceId);
        }

        public void Update(Race race)
        {
            _context.Races.Update(race);

            _context.SaveChanges();
        }
    }
}