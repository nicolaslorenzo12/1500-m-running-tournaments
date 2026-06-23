using Microsoft.AspNetCore.Mvc;
using RunningRaceSimulation.Entities;
using RunningRaceSimulation.Services.Interfaces;

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

        [HttpPost("race/{raceId}/start")]
        public async Task<ActionResult<Race>> StartRace(int raceId)
        {
            var raceResult = await _raceService.StartRaceAsync(raceId);

            // Later on, create a dto to return the race result

            return NoContent();
        }
    }
}