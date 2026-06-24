using RunningRaceSimulation.DTOs;

namespace RunningRaceSimulation.Services.Interfaces
{
    public interface IRaceService
    {
        Task<IReadOnlyList<RaceRunnerResultDTO>> StartRaceAsync(int raceId);
    }
}