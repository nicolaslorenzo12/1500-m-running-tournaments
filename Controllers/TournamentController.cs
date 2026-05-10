using Microsoft.AspNetCore.Mvc;
using _1500_m_race_simulation.Services.Interfaces;

namespace _1500_m_race_simulation.Controllers
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
            var tournament = _tournamentService.CreateTournament();

            return Ok(tournament);
        }
    }
}