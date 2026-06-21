namespace RunningRaceSimulation.DTOs
{
    public class CreatedRaceDTO
    {
        public string RoundType { get; init; }
        public List<CreatedRaceEntryDTO> EntryRaces { get; init; }
    }
}
