using Jupiter_Rover_Coding_Exercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jupiter_Rover_Coding_Exercise.Controllers
{
    [Route("[controller]")]
    public class RoverController : Controller
    {
        private readonly IMovingService _movingService;
        private readonly IRoverLocationService _roverLocationService;

        public RoverController(IMovingService movingService, IRoverLocationService roverLocationService)
        {
            _movingService = movingService;
            _roverLocationService = roverLocationService;
        }

        [HttpPut]
        public IActionResult Put(string commands = "")
        {
            var roverLocation = _movingService.Move(commands);

            return Ok(roverLocation);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roverLocationService.Get());
        }
    }
}
