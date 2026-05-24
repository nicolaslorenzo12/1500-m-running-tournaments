using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using running_race_simulation.Mappers;
using running_race_simulation.Services.Interfaces;

namespace running_race_simulation.Controllers
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