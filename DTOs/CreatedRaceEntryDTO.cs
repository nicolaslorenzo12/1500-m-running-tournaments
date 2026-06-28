namespace RunningRaceSimulation.DTOs
{
    public class CreatedRaceEntryDTO
    {
        public string RunnerName { get; }
        public int Ranking { get; }

        public CreatedRaceEntryDTO(
            string runnerName,
            int ranking)
        {
            RunnerName = runnerName;
            Ranking = ranking;
        }
    }
}