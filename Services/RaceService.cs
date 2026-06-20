using running_race_simulation.RaceSimulation;
using running_race_simulation.Repositories.Interfaces;
using running_race_simulation.Services.Interfaces;

namespace running_race_simulation.Services
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

            ArgumentNullException.ThrowIfNull(race);

            race.Start();

            _raceSimulator.Simulate(race);

            race.Complete();

            _raceRepository.Update(race);
        }
    }
}