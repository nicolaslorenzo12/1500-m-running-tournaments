using Microsoft.AspNetCore.Mvc;
using RunningRaceSimulation.DTOs;
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
        public async Task<ActionResult<IReadOnlyList<RaceRunnerResultDTO>>> StartRace(int raceId)
        {
            var raceResults = await _raceService.StartRaceAsync(raceId);

            return Ok(raceResults);
        }
    }
}