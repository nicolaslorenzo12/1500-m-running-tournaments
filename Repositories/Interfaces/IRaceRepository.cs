using RunningRaceSimulation.Entities;

namespace RunningRaceSimulation.Repositories.Interfaces
{
    public interface IRaceRepository
    {
        Race GetById(int raceId);

        void Update(Race race);
    }
}
