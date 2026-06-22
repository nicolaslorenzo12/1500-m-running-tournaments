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

        public void StartRace(int raceId)
        {
            var race = _raceRepository.GetById(raceId);

            _raceSimulator.Simulate(race);

            _raceRepository.Update(race);
        }
    }
}