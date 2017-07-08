namespace HexGridHelpers
{
    public struct IntSize
    {
        private readonly int _width;
        private readonly int _height;

        public IntSize(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public static bool operator ==(IntSize a, IntSize b)
        {
            return a.Width == b.Width && a.Height == b.Height;
        }

        public static bool operator !=(IntSize a, IntSize b)
        {
            return !(a == b);
        }

        public override bool Equals(object o)
        {
            if (o is IntSize)
                return this == (IntSize)o;
            return false;
        }
    }
}
