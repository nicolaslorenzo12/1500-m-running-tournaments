using running_race_simulation.Models;

namespace running_race_simulation.RaceSimulation
{
    public interface IRaceSimulator
    {
        void Simulate(Race race);
    }
}