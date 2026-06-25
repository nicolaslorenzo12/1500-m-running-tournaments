using RunningRaceSimulation.DTOs;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Mappers;
using RunningRaceSimulation.Models;
using RunningRaceSimulation.Repositories.Interfaces;
using RunningRaceSimulation.Services.Interfaces;

namespace RunningRaceSimulation.Services
{
    public class TournamentService : ITournamentService
    {
        private const int TotalTournamentRunners = 32;
        private const int RunnersPerRace = 8;

        private const int HeatRaceCount = 4;
        private const int SemifinalRaceCount = 2;
        private const int FinalRaceCount = 1;

        private readonly IRunnerRepository _runnerRepository;
        private readonly ITournamentRepository _tournamentRepository;
        private readonly TournamentMapper _tournamentMapper;

        public TournamentService(
            IRunnerRepository runnerRepository,
            ITournamentRepository tournamentRepository,
            TournamentMapper tournamentMapper)
        {
            _runnerRepository = runnerRepository;
            _tournamentRepository = tournamentRepository;
            _tournamentMapper = tournamentMapper;
        }

        public async Task<CreatedTournamentDTO> CreateTournamentAsync(string tournamentName)
        {
            var allRunners = _runnerRepository.GetAll();

            var selectedRunners = allRunners
                .OrderBy(r => Random.Shared.Next())
                .Take(TotalTournamentRunners)
                .ToList();

            var tournament = new Tournament(tournamentName);

            CreateHeatRaces(tournament, selectedRunners);

            CreateEmptyRaces(
                tournament,
                RoundType.Semifinal,
                SemifinalRaceCount);

            CreateEmptyRaces(
                tournament,
                RoundType.Final,
                FinalRaceCount);

            await _tournamentRepository.AddAsync(tournament);

            return _tournamentMapper.MapCreatedTournamentToDTO(tournament);
        }

        private void CreateHeatRaces(
            Tournament tournament,
            List<Runner> runners)
        {
            for (int i = 0; i < HeatRaceCount; i++)
            {
                var raceRunners = runners
                    .Skip(i * RunnersPerRace)
                    .Take(RunnersPerRace)
                    .ToList();

                var race = new Race(RoundType.Heats);

                var entries = raceRunners
                    .Select(r => new RaceEntry(r))
                    .ToList();

                race.AddEntries(entries);

                tournament.AddRace(race);
            }
        }

        private void CreateEmptyRaces(
            Tournament tournament,
            RoundType roundType,
            int raceCount)
        {
            for (int i = 0; i < raceCount; i++)
            {
                tournament.AddRace(new Race(roundType));
            }
        }
    }
}