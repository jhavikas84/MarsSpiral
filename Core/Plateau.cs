namespace VicRoads.MarsRover.Core
{
    public class Plateau
    {
        private int _X;
        private int _Y;
        public int X => _X;
        public int Y => _Y;

        public Plateau(int x, int y)
        {
            _X = x;
            _Y = y;
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }
    }
}
