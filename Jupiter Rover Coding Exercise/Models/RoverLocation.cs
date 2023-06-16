using Jupiter_Rover_Coding_Exercise.Enums;

namespace Jupiter_Rover_Coding_Exercise.Models
{
    public class RoverLocation
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public string Direction { get; private set; }

        public RoverLocation()
        {
            X = Constants.Constants.DefaultCoordinates;
            Y = Constants.Constants.DefaultCoordinates;
            Direction = ((Direction)Constants.Constants.DefaultDirection).ToString();
        }

        public void Update(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
