using RunningRaceSimulation.Entities;

namespace RunningRaceSimulation.Repositories.Interfaces
{
    public interface IRaceRepository
    {
        Task<Race?> GetByIdAsync(int raceId);
        Task UpdateAsync(Race race);
    }
}