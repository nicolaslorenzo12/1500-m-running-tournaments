using running_race_simulation.Models;

namespace running_race_simulation.RaceSimulation
{
    public class RaceSimulator : IRaceSimulator
    {
        private const int TotalSegments = 4;
        private const double DnfChancePerSegment = 0.2;

        public void Simulate(Race race)
        {
            var runnerStates = race.Entries
                .Select(e => new RunnerRaceState(e.Runner))
                .ToList();

            var segmentNumber = 0;

            while (segmentNumber < TotalSegments)
            {
                segmentNumber++;

                SimulateNextSegment(
                    runnerStates,
                    segmentNumber);
            }

            ApplyResults(
                race,
                runnerStates);
        }

        private void SimulateNextSegment(
            List<RunnerRaceState> runnerStates,
            int segmentNumber)
        {
            foreach (var runnerState in runnerStates)
            {
                bool runnerIsActive =
                    runnerState.Status != RunnerRaceStatus.DNF;

                bool runnerDNFsThisSegment =
                    runnerIsActive
                    && DidRunnerDNFInCurrentSegment();

                if (runnerDNFsThisSegment)
                {
                    runnerState.Status =
                        RunnerRaceStatus.DNF;
                }

                if (runnerState.Status != RunnerRaceStatus.DNF)
                {
                    var simulatedTime =
                        GenerateSegmentTime(
                            runnerState,
                            segmentNumber);

                    runnerState.SegmentTimes
                        .Add(simulatedTime);
                }
            }
        }

        private bool DidRunnerDNFInCurrentSegment()
        {
            return Random.Shared.NextDouble()
                < DnfChancePerSegment;
        }

        private double GenerateSegmentTime(
            RunnerRaceState runnerState,
            int segmentNumber)
        {
            var profile =
                RaceSimulationConfiguration
                    .SegmentProfiles[segmentNumber];

            var baseTime =
                RaceSimulationConfiguration
                    .BaseSegmentTimes[segmentNumber];

            var strength =
                CalculateStrength(
                    runnerState.Runner.Ranking);

            var rankingAdvantage =
                strength
                * profile.RankingInfluence;

            var variation =
                GenerateVariation(
                    profile.PerformanceVariation);

            return baseTime
                - rankingAdvantage
                + variation;
        }

        private double CalculateStrength(
            int ranking)
        {
            return 1.0 / Math.Sqrt(ranking);
        }

        private double GenerateVariation(
            double performanceVariation)
        {
            return Random.Shared.NextDouble()
                * (performanceVariation * 2)
                - performanceVariation;
        }

        private void ApplyResults(
            Race race,
            List<RunnerRaceState> runnerStates)
        {
            MarkFinishedRunners(
                runnerStates);

            var orderedRunners =
                RankRunners(
                    runnerStates);

            for (int position = 0;
                position < orderedRunners.Count;
                position++)
            {
                var runnerState =
                    orderedRunners[position];

                var raceEntry = race.Entries.Single(
                    e => e.RunnerId ==
                        runnerState.Runner.Id);

                raceEntry.SetResult(
                    position + 1,
                    CalculateRaceTime(runnerState),
                    runnerState.Status);
            }
        }

        private void MarkFinishedRunners(
            List<RunnerRaceState> runnerStates)
        {
            foreach (var runnerState in runnerStates)
            {
                if (runnerState.Status != RunnerRaceStatus.DNF)
                {
                    runnerState.Status =
                        RunnerRaceStatus.Finished;
                }
            }
        }

        private List<RunnerRaceState> RankRunners(
            List<RunnerRaceState> runnerStates)
        {
            return runnerStates
                .OrderBy(r => r.Status == RunnerRaceStatus.DNF)
                .ThenBy(r => r.TotalTime)
                .ToList();
        }

        private double CalculateRaceTime(
            RunnerRaceState runnerState)
        {
            return runnerState.Status ==
                RunnerRaceStatus.DNF
                    ? 0
                    : runnerState.TotalTime;
        }
    }
}