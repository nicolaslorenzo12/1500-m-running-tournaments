using running_race_simulation.RaceSimulation;

namespace running_race_simulation.RaceSimulation
{
    public static class RaceSimulationConfiguration
    {
        public static readonly Dictionary<int, SegmentProfile>
          SegmentProfiles = new()
      {
            { 1, new SegmentProfile(2, 2) },
            { 2, new SegmentProfile(4.8, 1.5) },
            { 3, new SegmentProfile(6, 1) },
            { 4, new SegmentProfile(8, 0.5) }
      };

        public static readonly Dictionary<int, double>
            BaseSegmentTimes = new()
        {
            { 1, 63 },
            { 2, 60 },
            { 3, 58 },
            { 4, 44 }
        };
    }
}
