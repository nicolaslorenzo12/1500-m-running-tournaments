using running_race_simulation.Models;

namespace running_race_simulation.Services.Interfaces
{
    public interface ITournamentService
    {
        Tournament CreateTournament(string tournamentName);
    }
}