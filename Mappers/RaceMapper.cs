using RunningRaceSimulation.DTOs;
using RunningRaceSimulation.Entities;

namespace RunningRaceSimulation.Mappers
{
    public class RaceMapper
    {
        public IReadOnlyList<RaceRunnerResultDTO> RaceResultsToDTO(Race race)
        {
            return race.Entries
                .Select(entry => new RaceRunnerResultDTO(
                    entry.Runner.Name,
                    entry.Runner.Ranking,
                    entry.Position,
                    TimeSpan.FromSeconds(entry.Time).ToString(@"m\:ss"),
                    entry.Status))
                .ToList();
        }
    }
}