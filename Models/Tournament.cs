using System.Diagnostics;

namespace running_race_simulation.Models
{
    public class Tournament
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = null!;

        public List<Race> Races { get; private set; } = new();

        private Tournament() { }

        public Tournament(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "Tournament name cannot be empty.");
            }

            Name = name;
        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }
    }
}