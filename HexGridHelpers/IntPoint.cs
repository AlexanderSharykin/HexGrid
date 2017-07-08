namespace HexGridHelpers
{
    public struct IntPoint
    {
        private readonly int _x;
        private readonly int _y;

        public IntPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public static bool operator ==(IntPoint a, IntPoint b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(IntPoint a, IntPoint b)
        {
            return !(a == b);
        }

        public override bool Equals(object o)
        {
            if (o is IntPoint)
                return this == (IntPoint)o;
            return false;
        }
    }
}
