using RunningRaceSimulation.Data;
using RunningRaceSimulation.Models;
using RunningRaceSimulation.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace RunningRaceSimulation.Repositories
{
    public class TournamentRepository : ITournamentRepository
    {
        private readonly AppDbContext _context;

        public TournamentRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Tournament tournament)
        {
            _context.Tournaments.Add(tournament);
            _context.SaveChanges();
        }

        public Tournament? GetById(int id)
        {
            return _context.Tournaments
                .Include(t => t.Races)
                    .ThenInclude(r => r.Entries)
                        .ThenInclude(e => e.Runner)
                .FirstOrDefault(t => t.Id == id);
        }
    }
}