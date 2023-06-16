using Jupiter_Rover_Coding_Exercise.Models;
using Jupiter_Rover_Coding_Exercise.Repositories.Interfaces;

namespace Jupiter_Rover_Coding_Exercise.Repositories
{
    public class RoverLocationRepository : IRoverLocationRepository
    {
        private readonly RoverLocation _roverLocation = new();

        public RoverLocation Get()
        {
            return _roverLocation;
        }
    }
}
