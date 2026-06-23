using RunningRaceSimulation.Entities;

namespace RunningRaceSimulation.Services.Interfaces
{
    public interface IRaceService
    {
        Task<Race> StartRaceAsync(int raceId);
    }
}
