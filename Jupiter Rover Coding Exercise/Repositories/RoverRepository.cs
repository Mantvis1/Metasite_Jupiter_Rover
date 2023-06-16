using Jupiter_Rover_Coding_Exercise.Models;
using Jupiter_Rover_Coding_Exercise.Repositories.Interfaces;

namespace Jupiter_Rover_Coding_Exercise.Repositories
{
    public class RoverRepository : IRoverRepository 
    {
        private readonly Rover _rover;

        public RoverRepository(IRoverLocationRepository roverLocationRepository)
        {
            _rover = new Rover(roverLocationRepository.Get());
        }

        public Rover GetRover()
        {
            return _rover;
        }
    }
}
