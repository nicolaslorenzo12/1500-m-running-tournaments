using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using RunningRaceSimulation.DTOs;
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
        public async Task<ActionResult<CreatedTournamentDTO>> CreateTournament([FromBody] string name)
        {
            return Ok(await _tournamentService.CreateTournamentAsync(name));
        }
    }
}