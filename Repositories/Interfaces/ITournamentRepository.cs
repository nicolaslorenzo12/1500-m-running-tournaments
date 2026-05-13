using _1500_m_race_simulation.Models;

public interface ITournamentRepository
{
    void Add(Tournament tournament);
    Tournament? GetById(int id);
}