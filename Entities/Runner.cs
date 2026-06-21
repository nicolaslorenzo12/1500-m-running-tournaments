namespace RunningRaceSimulation.Models
{
    public class Runner
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Ranking { get; set; }

        public Runner() { }

        public Runner(string name,int ranking)
        {

            Name = name;
            Ranking = ranking;
        }
    }
}