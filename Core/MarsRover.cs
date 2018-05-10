namespace VicRoads.MarsRover.Core
{
    public class MarsRover : IMarsRover
    {
        private int _RoverPositionX;
        private int _RoverPositionY;
        private string _Direction;
        private Plateau _Plateau;
        private Direction _CurrentDirection;

        public enum Direction
        {
            North = 1,
            East,
            South,
            West
        }

        public int RoverPositionX { get => _RoverPositionX; set => _RoverPositionX = value; }
        public int RoverPositionY { get => _RoverPositionY; set => _RoverPositionY = value; }

        public Direction CurrentDirection { get => _CurrentDirection; set => _CurrentDirection = value; }
        public Plateau ThePlateau { get => _Plateau; set => _Plateau = value; }

        public MarsRover(int x, int y, Direction direction, Plateau plateau)
        {
            if (x >= 0 && y >= 0 && x <= plateau.X && y <= plateau.Y)
            {
                RoverPositionX = x;
                RoverPositionY = y;
            }
            _CurrentDirection = direction;
            _Plateau = plateau;
        }

        public void ProcessRoverInstruction(string commands)
        {
            foreach (char character in commands)
            {
                switch (character)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveRover();
                        break;
                }
            }
        }

        public void MoveRover()
        {
            switch (CurrentDirection)
            {
                case Direction.North:
                    if (RoverPositionY <= ThePlateau.Y)
                        RoverPositionY += 1;
                    break;
                case Direction.East:
                    if (RoverPositionX <= ThePlateau.X)
                        RoverPositionX += 1;
                    break;
                case Direction.South:
                    if (RoverPositionY <= ThePlateau.Y)
                        RoverPositionY -= 1;
                    break;
                case Direction.West:
                    if (RoverPositionX <= ThePlateau.X)
                        RoverPositionX -= 1;
                    break;
            }
        }

        public void TurnLeft()
        {
            bool flag = false;

            switch (CurrentDirection)
            {
                case Direction.North:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.East;
                        flag = true;
                    }
                    break;
                case Direction.East:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.South;
                        flag = true;
                    }
                    break;
                case Direction.South:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.West;
                        flag = true;
                    }
                    break;
                case Direction.West:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.North;
                        flag = true;
                    }
                    break;
            }
        }

        public void TurnRight()
        {
            bool flag = false;

            switch (CurrentDirection)
            {
                case Direction.North:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.West;
                        flag = true;
                    }
                    break;
                case Direction.East:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.North;
                        flag = true;
                    }
                    break;
                case Direction.South:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.East;
                        flag = true;
                    }
                    break;
                case Direction.West:
                    if (flag != true)
                    {
                        CurrentDirection = Direction.South;
                        flag = true;
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"{RoverPositionX}  {RoverPositionY}  {CurrentDirection.ToString()}";            
        }
    }
}
