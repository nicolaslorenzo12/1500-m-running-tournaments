using RunningRaceSimulation.DTOs;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Mappers
{
    public static class TournamentMapper
    {

        public static CreatedTournamentDTO MapCreatedTournamentToDTO(Tournament tournament)
        {
            return new CreatedTournamentDTO
            {
                Name = tournament.Name,
                Races = tournament.Races.Select(MapCreatedRaceToDTO).ToList()
            };
        }

        private static CreatedRaceDTO MapCreatedRaceToDTO(Race race)
        {
            return new CreatedRaceDTO
            {
                RoundType = race.RoundType.ToString(),
                EntryRaces = race.Entries.Select(MapCreatedRaceEntryToDTO).ToList()
            };
        }

        private static CreatedRaceEntryDTO MapCreatedRaceEntryToDTO(RaceEntry raceEntry)
        {
            return new CreatedRaceEntryDTO
            {
                RunnerName = raceEntry.Runner.Name,
                Ranking = raceEntry.Runner.Ranking
            };
        }
    }

}
