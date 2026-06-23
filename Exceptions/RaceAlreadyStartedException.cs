using RunningRaceSimulation.Entities;

namespace RunningRaceSimulation.Exceptions;

public class RaceAlreadyStartedException : Exception
{
    public RaceAlreadyStartedException(Race race)
        : base($"The status of race with ID {race.Id} is {race.Status}")
    {
    }
}