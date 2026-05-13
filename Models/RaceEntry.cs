namespace _1500_m_race_simulation.Models
{
    public class RaceEntry
    {
        public int Id { get; private set; }

        public int RunnerId { get; private set; }

        public Runner Runner { get; private set; } = null!;

        public int? Position { get; private set; }

        public double? Time { get; private set; }

        public ResultStatus Status { get; private set; }

        private RaceEntry() { }

        public RaceEntry(Runner runner)
        {
            if (runner == null)
            {
                throw new ArgumentNullException(nameof(runner));
            }

            Runner = runner;
            RunnerId = runner.Id;
            Status = ResultStatus.Pending;
        }
    }
}