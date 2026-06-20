using running_race_simulation.Models;

namespace running_race_simulation.Models
{
    public class Race
    {
        public int Id { get; private set; }

        public RoundType RoundType { get; private set; }

        public RaceStatus Status { get; private set; }

        public List<RaceEntry> Entries { get; private set; } = new();

        private Race() { }

        public Race(RoundType roundType)
        {
            RoundType = roundType;
            Status = RaceStatus.NotStarted;
        }

        public void AddRunners(List<Runner> runners)
        {

            if (runners.Count != 8)
            {
                throw new ArgumentException(
                    "A race must have exactly 8 runners.");
            }

            foreach (var runner in runners)
            {
                Entries.Add(new RaceEntry(runner));
            }
        }

        public void Start()
        {
            if (Status != RaceStatus.NotStarted)
            {
                throw new InvalidOperationException(
                    "Race has already started.");
            }

            Status = RaceStatus.InProgress;
        }

        public void Complete()
        {
            if (Status != RaceStatus.InProgress)
            {
                throw new InvalidOperationException(
                    "Race is not in progress.");
            }

            Status = RaceStatus.Completed;
        }

        public void LoadEntries(List<RaceEntry> entries)
        {
            ArgumentNullException.ThrowIfNull(entries);

            Entries = entries;
        }
    }
}