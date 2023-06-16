using Jupiter_Rover_Coding_Exercise.Models;
using Jupiter_Rover_Coding_Exercise.Repositories.Interfaces;

namespace Jupiter_Rover_Coding_Exercise.Services
{
    public class RoverLocationService : IRoverLocationService
    {
        private readonly IRoverLocationRepository _roverLocationRepository;

        public RoverLocationService(IRoverLocationRepository roverLocationRepository)
        {
            _roverLocationRepository = roverLocationRepository;
        }

        public RoverLocation Get()
        {
            return _roverLocationRepository.Get();
        }
    }
}
