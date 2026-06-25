namespace RunningRaceSimulation.DTOs
{
    public class RaceRunnerResultDTO
    {
        public string RunnerName { get; }
        public int RunnerRanking { get; }
        public int Position { get; }
        public string FinishTime { get; }
        public string RunnerRaceStatus { get; }

        public RaceRunnerResultDTO(
            string runnerName,
            int runnerRanking,
            int position,
            string finishTime,
            RunnerRaceStatus runnerRaceStatus)
        {
            RunnerName = runnerName;
            RunnerRanking = runnerRanking;
            Position = position;
            FinishTime = finishTime;
            RunnerRaceStatus = runnerRaceStatus.ToString();
        }
    }
}
