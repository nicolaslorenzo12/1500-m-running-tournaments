using RunningRaceSimulation.Models;

public interface ITournamentRepository
{
    Task AddAsync(Tournament tournament);
    Task<Tournament?> GetByIdAsync(int id);
}