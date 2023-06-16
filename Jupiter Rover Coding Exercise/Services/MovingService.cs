using Jupiter_Rover_Coding_Exercise.Models;
using Jupiter_Rover_Coding_Exercise.Repositories.Interfaces;

namespace Jupiter_Rover_Coding_Exercise.Services
{
    public class MovingService : IMovingService
    {
        private readonly IRoverRepository _roverRepository;

        public MovingService(IRoverRepository roverRepository)
        {
            _roverRepository = roverRepository;
        }

        public RoverLocation Move(string commands)
        {
            var rover = _roverRepository.GetRover();

            foreach (var command in commands.ToUpper())
            {
                switch (command)
                {
                    case 'F': rover.MoveForward();
                        break;

                    case 'B': rover.MoveBackwards();
                        break;

                    case 'L': rover.TurnLeft();
                        break;

                    case 'R': rover.TurnRight();
                        break;

                    default:
                        throw new ArgumentException("Command is invalid");
                }
            }

            return rover.GetCurrentLocation();
        }
    }
}
