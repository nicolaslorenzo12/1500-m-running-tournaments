using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.RaceSimulation
{
    public class RaceSimulator : IRaceSimulator
    {
        private const int TotalSegments = 4;
        private const double DnfChancePerSegment = 0.2;

        public void Simulate(Race race)
        {
            race.Status = RaceStatus.InProgress;

            var runners = race.Entries
                .Select(e => new RunnerRaceState(e.Runner))
                .ToList();

            for (int segment = 1; segment <= TotalSegments; segment++)
            {
                SimulateSegment(runners, segment);
            }

            MarkFinishedRunners(runners);
            ApplyResults(race, runners);

            race.Status = RaceStatus.Completed;
        }

        private void SimulateSegment(List<RunnerRaceState> runners, int segment)
        {
            var profile = RaceSimulationConfiguration.SegmentProfiles[segment];
            var baseTime = RaceSimulationConfiguration.BaseSegmentTimes[segment];

            foreach (var runner in runners)
            {
                if (runner.Status != RunnerRaceStatus.DNF)
                {
                    if (Random.Shared.NextDouble() < DnfChancePerSegment)
                    {
                        runner.Status = RunnerRaceStatus.DNF;
                    }
                    else
                    {
                        runner.SegmentTimes.Add(
                            CalculateSegmentTime(runner, profile, baseTime));
                    }
                }
            }
        }

        private double CalculateSegmentTime(
            RunnerRaceState runner,
            SegmentProfile profile,
            double baseTime)
        {
            var strength =
                1.0 / Math.Sqrt(runner.Runner.Ranking);

            return baseTime
                - (strength * profile.RankingInfluence)
                + GenerateVariation(profile.PerformanceVariation);
        }

        private double GenerateVariation(double variation)
        {
            return Random.Shared.NextDouble()
                * (variation * 2)
                - variation;
        }

        private void MarkFinishedRunners(
            IEnumerable<RunnerRaceState> runners)
        {
            foreach (var runner in runners)
            {
                if (runner.Status != RunnerRaceStatus.DNF)
                {
                    runner.Status = RunnerRaceStatus.Finished;
                }
            }
        }

        private void ApplyResults(
            Race race,
            List<RunnerRaceState> runners)
        {
            var rankedRunners = runners
                .OrderBy(r => r.Status == RunnerRaceStatus.DNF)
                .ThenBy(r => r.TotalTime)
                .ToList();

            for (int position = 0; position < rankedRunners.Count; position++)
            {
                var runner = rankedRunners[position];

                var entry = race.Entries.Single(
                    e => e.RunnerId == runner.Runner.Id);

                entry.Position = position + 1;
                entry.Status = runner.Status;
                entry.Time = runner.Status == RunnerRaceStatus.DNF
                    ? 0
                    : runner.TotalTime;
            }
        }
    }
}