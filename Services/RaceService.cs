using RunningRaceSimulation.DTOs;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Exceptions;
using RunningRaceSimulation.Mappers;
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
        private readonly RaceMapper _raceMapper;

        public RaceService(
            IRaceRepository raceRepository,
            IRaceSimulator raceSimulator, RaceMapper raceMapper)
        {
            _raceRepository = raceRepository;
            _raceSimulator = raceSimulator;
            _raceMapper = raceMapper;
        }

        public async Task<IReadOnlyList<RaceRunnerResultDTO>> StartRaceAsync(int raceId)
        {
            var race = await FindRace(raceId);

            CheckRaceNotStarted(race);

            _raceSimulator.Simulate(race);

            await _raceRepository.UpdateAsync(race);

            return _raceMapper.RaceResultsToDTO(race);
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