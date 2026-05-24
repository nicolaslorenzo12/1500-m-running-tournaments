namespace running_race_simulation.Models
{
    public class Runner
    {
        public int Id { get; private set; }

        public string Name { get; private set; } = null!;

        public int Ranking { get; private set; }

        private Runner() { }

        public Runner(
            string name,
            int ranking)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(
                    "Name cannot be empty.");
            }

            Name = name;

            SetRanking(ranking);
        }

        public void UpdateRanking(int ranking)
        {
            SetRanking(ranking);
        }

        private void SetRanking(int ranking)
        {
            if (ranking <= 0)
            {
                throw new ArgumentException(
                    "Ranking must be greater than 0.");
            }

            Ranking = ranking;
        }
    }
}