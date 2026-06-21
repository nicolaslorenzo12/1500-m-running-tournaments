using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Services.Interfaces
{
    public interface ITournamentService
    {
        Tournament CreateTournament(string tournamentName);
    }
}