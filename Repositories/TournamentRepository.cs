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

        public async Task AddAsync(Tournament tournament)
        {
            await _context.Tournaments.AddAsync(tournament);
            await _context.SaveChangesAsync();
        }

        public async Task<Tournament?> GetByIdAsync(int id)
        {
            return await _context.Tournaments
                .Include(t => t.Races)
                    .ThenInclude(r => r.Entries)
                        .ThenInclude(e => e.Runner)
                .FirstOrDefaultAsync(t => t.Id == id);
        }
    }
}