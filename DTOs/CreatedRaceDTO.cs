namespace RunningRaceSimulation.DTOs
{
    public class CreatedRaceDTO
    {
        public string RoundType { get; }
        public IReadOnlyList<CreatedRaceEntryDTO> EntryRaces { get; }

        public CreatedRaceDTO(string roundType, IReadOnlyList<CreatedRaceEntryDTO> entryRaces)
        {
            RoundType = roundType;
            EntryRaces = entryRaces;
        }
    }
}
