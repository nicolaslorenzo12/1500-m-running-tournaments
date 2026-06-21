using RunningRaceSimulation.Entities;

namespace RunningRaceSimulation.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Race> Races { get; set; } = new();

        public Tournament() { }

        public Tournament(string name)
        {
            Name = name;
        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }
    }
}