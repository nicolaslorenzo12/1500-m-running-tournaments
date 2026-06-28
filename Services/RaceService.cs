using RunningRaceSimulation.DTOs;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Exceptions;
using RunningRaceSimulation.Models;
using RunningRaceSimulation.RaceSimulation;
using RunningRaceSimulation.Repositories.Interfaces;
using RunningRaceSimulation.Services.Interfaces;

namespace RunningRaceSimulation.Services
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository _raceRepository;
        private readonly IRaceSimulator _raceSimulator;

        public RaceService(
            IRaceRepository raceRepository,
            IRaceSimulator raceSimulator)
        {
            _raceRepository = raceRepository;
            _raceSimulator = raceSimulator;
        }

        public async Task<IReadOnlyList<RaceRunnerResultDTO>> StartRaceAsync(int raceId)
        {
            var race = await FindRace(raceId);

            CheckRaceNotStarted(race);

            _raceSimulator.Simulate(race);

            await _raceRepository.UpdateAsync(race);

            return race.Entries
                .OrderBy(entry => entry.Position)
                .Select(entry => new RaceRunnerResultDTO(
                    entry.Runner.Name,
                    entry.Runner.Ranking,
                    entry.Position,
                    TimeSpan.FromSeconds(entry.Time).ToString(@"m\:ss\.fff"),
                    entry.Status))
                .ToList();
        }

        private async Task<Race> FindRace(int raceId)
        {
            return await _raceRepository.GetByIdAsync(raceId)
                ?? throw new RaceNotFoundException(raceId);
        }

        private void CheckRaceNotStarted(Race race)
        {
            if (race.Status is RaceStatus.InProgress or RaceStatus.Completed)
            {
                throw new RaceAlreadyStartedException(race);
            }
        }
    }
}