namespace _1500_m_race_simulation.Models
{
    public class Race
    {
        public int Id { get; private set; }

        public RoundType RoundType { get; private set; }

        public List<Runner> Runners { get; private set; } = new();

        public List<RunnerResult> Results { get; private set; } = new();

        private Race() { }

        public Race(RoundType roundType)
        {
            RoundType = roundType;
        }

        public void AddRunners(List<Runner> runners)
        {
            if (Runners.Count > 0)
                throw new InvalidOperationException(
                    "Runners have already been assigned.");

            if (runners == null || runners.Count != 8)
                throw new ArgumentException(
                    "A race must have exactly 8 runners.");

            Runners.AddRange(runners);
        }

        public void SetResults(List<RunnerResult> results)
        {
            EnsureRunnersAssigned();
            EnsureResultsNotAlreadySet();
            ValidateResultsBasic(results);
            ValidateResultsMatchRunners(results);
            ValidatePositions(results);

            Results.AddRange(results);
        }

        private void EnsureRunnersAssigned()
        {
            if (Runners.Count != 8)
                throw new InvalidOperationException(
                    "Runners must be assigned before setting results.");
        }

        private void EnsureResultsNotAlreadySet()
        {
            if (Results.Count > 0)
                throw new InvalidOperationException(
                    "Results have already been set.");
        }

        private void ValidateResultsBasic(
            List<RunnerResult> results)
        {
            if (results == null || results.Count != 8)
                throw new ArgumentException(
                    "A race must have exactly 8 results.");
        }

        private void ValidateResultsMatchRunners(
            List<RunnerResult> results)
        {
            var runnerSet = Runners.ToHashSet();

            if (results.Any(r => !runnerSet.Contains(r.Runner)))
                throw new ArgumentException(
                    "Results must match race runners.");
        }

        private void ValidatePositions(
            List<RunnerResult> results)
        {
            var finished = results
                .Where(r => r.Status == ResultStatus.Finished)
                .ToList();

            var positions = finished
                .Select(r => r.Position!.Value)
                .ToList();

            if (positions.Count != positions.Distinct().Count())
                throw new ArgumentException(
                    "Positions must be unique.");

            var expected = Enumerable.Range(1, positions.Count);

            if (!positions
                .OrderBy(p => p)
                .SequenceEqual(expected))
            {
                throw new ArgumentException(
                    "Positions must be sequential starting from 1.");
            }
        }
    }
}