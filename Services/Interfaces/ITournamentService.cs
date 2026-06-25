using RunningRaceSimulation.DTOs;
using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Services.Interfaces
{
    public interface ITournamentService
    {
        Task<CreatedTournamentDTO> CreateTournamentAsync(string tournamentName);
    }
}