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
        public IActionResult CreateTournament()
        {
            var createdTournament = _tournamentService.CreateTournament();

            return Ok(TournamentMapper.MapCreatedTournamentToDTO(createdTournament));
        }
    }
}