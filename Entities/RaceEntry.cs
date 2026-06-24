using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Entities
{
    public class RaceEntry
    {
        public int Id { get; set; }

        public int RunnerId { get; set; }

        public Runner Runner { get; set; } = null!;

        public int Position { get; set; }

        public double Time { get; set; }

        public RunnerRaceStatus Status { get; set; }

        public RaceEntry()
        {

        }

        public RaceEntry(Runner runner)
        {
            RunnerId = runner.Id;
            Runner = runner;
        }
    }

}