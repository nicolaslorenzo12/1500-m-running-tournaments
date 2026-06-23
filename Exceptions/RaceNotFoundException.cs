namespace RunningRaceSimulation.Exceptions;

public class RaceNotFoundException : Exception
{
    public RaceNotFoundException(int raceId)
        : base($"Race {raceId} not found")
    {
    }
}