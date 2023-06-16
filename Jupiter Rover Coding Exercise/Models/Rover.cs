using Jupiter_Rover_Coding_Exercise.Enums;

namespace Jupiter_Rover_Coding_Exercise.Models
{
    public class Rover
    {
        private Direction _direction;

        private int _x;

        private int _y;

        private readonly RoverLocation _roverLocation;

        public Rover(RoverLocation roverLocation)
        {
            _roverLocation = roverLocation;
        }

        public void MoveForward()
        {
            switch (_direction)
            {
                case Direction.West:
                    _x--;
                    break;
                case Direction.East:
                    _x++;
                    break;
                case Direction.North:
                    _y++;
                    break;
                case Direction.South:
                    _y--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _roverLocation.Update(_x,_y,_direction.ToString());
        }

        public void MoveBackwards()
        {
            switch (_direction)
            {
                case Direction.West:
                    _x++;
                    break;
                case Direction.East:
                    _x--;
                    break;
                case Direction.North:
                    _y--;
                    break;
                case Direction.South:
                    _y++;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _roverLocation.Update(_x, _y, _direction.ToString());
        }

        public void TurnLeft()
        {
            _direction--;

            if ((int)_direction < Constants.Constants.MinDirection)
            {
                _direction = (Direction)Constants.Constants.MaxDirection;
            }

            _roverLocation.Update(_x, _y, _direction.ToString());
        }

        public void TurnRight()
        {
            _direction++;

            if ((int)_direction > Constants.Constants.MaxDirection)
            {
                _direction = (Direction)Constants.Constants.MinDirection;
            }

            _roverLocation.Update(_x, _y, _direction.ToString());
        }

        public RoverLocation GetCurrentLocation()
        {
            return _roverLocation;
        }
    }
}
