using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using RunningRaceSimulation.Mappers;
using RunningRaceSimulation.Services.Interfaces;

namespace RunningRaceSimulation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TournamentController : ControllerBase
    {
        private readonly ITournamentService _tournamentService;

        public TournamentController(
            ITournamentService tournamentService)
        {
            _tournamentService = tournamentService;
        }

        [HttpPost]
        public IActionResult CreateTournament([FromBody] string name)
        {
            var createdTournament = _tournamentService.CreateTournament(name);

            return Ok(TournamentMapper.MapCreatedTournamentToDTO(createdTournament));
        }
    }
}