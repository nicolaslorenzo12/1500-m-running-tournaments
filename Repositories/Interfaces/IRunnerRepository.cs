using running_race_simulation.Models;

namespace running_race_simulation.Repositories.Interfaces
{
    public interface IRunnerRepository
    {
        List<Runner> GetAll();
    }
}