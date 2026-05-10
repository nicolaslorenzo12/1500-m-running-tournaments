namespace _1500_m_race_simulation.Models
{
    public class Tournament
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = null!;

        public List<Race> Races { get; private set; } = new();

        private Tournament() { }

        public Tournament(string name)
        {
            SetName(name);
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "Tournament name cannot be empty.");
            }

            Name = name;
        }
    }
}