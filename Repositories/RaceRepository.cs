using Microsoft.EntityFrameworkCore;
using RunningRaceSimulation.Data;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Repositories.Interfaces;

public class RaceRepository : IRaceRepository
{
    private readonly AppDbContext _context;

    public RaceRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Race?> GetByIdAsync(int raceId)
    {
        return await _context.Races
            .Include(r => r.Entries)
                .ThenInclude(e => e.Runner)
            .SingleOrDefaultAsync(r => r.Id == raceId);
    }

    public async Task UpdateAsync(Race race)
    {
        _context.Races.Update(race);

        await _context.SaveChangesAsync();
    }
}