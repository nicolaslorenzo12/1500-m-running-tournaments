namespace RunningRaceSimulation.DTOs
{
    public class CreatedTournamentDTO
    {
        public string Name { get; }
        public IReadOnlyList<CreatedRaceDTO> Races { get; }

        public CreatedTournamentDTO(
            string name,
            IReadOnlyList<CreatedRaceDTO> races)
        {
            Name = name;
            Races = races;
        }
    }
}