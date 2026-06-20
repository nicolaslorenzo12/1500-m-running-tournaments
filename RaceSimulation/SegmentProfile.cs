namespace running_race_simulation.RaceSimulation
{
    public record SegmentProfile(
        double RankingInfluence, // With this I penalize runners with high rankings
        double PerformanceVariation); // How unpredictable the segment is
}
