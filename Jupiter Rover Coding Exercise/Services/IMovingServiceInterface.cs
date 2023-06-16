using Jupiter_Rover_Coding_Exercise.Models;

namespace Jupiter_Rover_Coding_Exercise.Services
{
    public interface IMovingService
    {
        RoverLocation Move(string commands);
    }
}
