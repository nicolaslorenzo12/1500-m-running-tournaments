using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Repositories.Interfaces
{
    public interface IRunnerRepository
    {
        List<Runner> GetAll();
    }
}