using RunningRaceSimulation.Models;

namespace RunningRaceSimulation.Entities
{
    public class Race
    {
        public int Id { get; set; }

        public RoundType RoundType { get; set; }

        public RaceStatus Status { get; set; }

        public List<RaceEntry> Entries { get; set; } = new();

        public Race() { }

        public Race(RoundType roundType)
        {
            RoundType = roundType;
            Status = RaceStatus.NotStarted;
        }

        public void AddEntries(List<RaceEntry> entries)
        {
            Entries = entries;
        }
    }
}