namespace _1500_m_race_simulation.Models
{
    public class RunnerResult
    {
        public int Id { get; private set; }

        public Runner Runner { get; private set; } = null!;

        public int? Position { get; private set; }

        public double? Time { get; private set; }

        public ResultStatus Status { get; private set; }

        private RunnerResult() { }

        public RunnerResult(
            Runner runner,
            int? position,
            double? time,
            ResultStatus status)
        {
            ValidateResult(position, time, status);

            Runner = runner;
            Position = position;
            Time = time;
            Status = status;
        }



        private void ValidateResult(
            int? position,
            double? time,
            ResultStatus status)
        {
            switch (status)
            {
                case ResultStatus.Finished:
                    ValidateFinishedResult(position, time);
                    break;

                case ResultStatus.DNF:
                    ValidateDnfResult(position, time);
                    break;
            }
        }

        private void ValidateFinishedResult(
            int? position,
            double? time)
        {
            if (!position.HasValue || position < 1)
            {
                throw new ArgumentException(
                    "Finished runners must have a valid position.");
            }

            if (!time.HasValue || time <= 0)
            {
                throw new ArgumentException(
                    "Finished runners must have a valid time.");
            }
        }

        private void ValidateDnfResult(
            int? position,
            double? time)
        {
            if (position.HasValue)
            {
                throw new ArgumentException(
                    "DNF runners cannot have a position.");
            }

            if (time.HasValue)
            {
                throw new ArgumentException(
                    "DNF runners cannot have a time.");
            }
        }
    }
}