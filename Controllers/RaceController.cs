using RunningRaceSimulation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace RunningRaceSimulation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService _raceService;

        public RaceController(IRaceService raceService)
        {
            _raceService = raceService;
        }

        [HttpPost("{raceId}/start")]
        public IActionResult StartRace(int raceId)
        {
            _raceService.StartRace(raceId);

            return NoContent();
        }
    }
}