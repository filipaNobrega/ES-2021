namespace Exercise7
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point Empty { get; } = new Point(int.MinValue, int.MinValue);

        public static Point Parse(string x, string y)
        {
            var point = new Point();

            if (!int.TryParse(x, out point.X)) return Empty;
            if (!int.TryParse(y, out point.Y)) return Empty;

            return point;
        }

        public static bool TryParse(string x, string y, out Point point)
        {
            point.X = point.Y = -1;
            if (!int.TryParse(x, out point.X)) return false;
            if (!int.TryParse(y, out point.Y)) return false;

            return true;
        }

        public bool Equals(Point point)
        {
            return X == point.X && Y == point.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Point point && Equals(point);
        }

        public static bool operator ==(Point point1, Point point2)
        {
            return point1.Equals(point2);
        }

        public static bool operator !=(Point point1, Point point2)
        {
            return !point1.Equals(point2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}