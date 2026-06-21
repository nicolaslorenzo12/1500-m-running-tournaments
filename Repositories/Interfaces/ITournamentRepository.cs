using RunningRaceSimulation.Models;

public interface ITournamentRepository
{
    void Add(Tournament tournament);
    Tournament? GetById(int id);
}