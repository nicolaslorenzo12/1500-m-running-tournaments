using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.RaceSimulation
{
    public class RunnerRaceState
    {
        public Runner Runner { get; }

        public List<double> SegmentTimes { get; } = [];

        public RunnerRaceStatus Status { get; set; }

        // Calculates totaltime when accessed
        public double TotalTime =>
            SegmentTimes.Sum();

        public RunnerRaceState(
            Runner runner)
        {
            ArgumentNullException.ThrowIfNull(runner);

            Runner = runner;
            Status = RunnerRaceStatus.Pending;
        }
    }
}