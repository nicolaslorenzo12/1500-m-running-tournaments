using running_race_simulation.Models;

namespace running_race_simulation.Repositories.Interfaces
{
    public interface IRaceRepository
    {
        Race GetById(int raceId);

        void Update(Race race);
    }
}
