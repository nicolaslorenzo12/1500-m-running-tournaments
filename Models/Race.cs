namespace running_race_simulation.Models
{
    public class Race
    {
        public int Id { get; private set; }

        public RoundType RoundType { get; private set; }

        public List<RaceEntry> Entries { get; private set; } = new();

        private Race() { }

        public Race(RoundType roundType)
        {
            RoundType = roundType;
        }

        public void AddRunners(List<Runner> runners)
        {
            if (Entries.Count > 0)
            {
                throw new InvalidOperationException(
                    "Runners have already been assigned.");
            }

            if (runners == null || runners.Count != 8)
            {
                throw new ArgumentException(
                    "A race must have exactly 8 runners.");
            }

            foreach (var runner in runners)
            {
                Entries.Add(new RaceEntry(runner));
            }
        }
    }
}