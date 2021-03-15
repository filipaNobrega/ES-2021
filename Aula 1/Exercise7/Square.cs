using System;
using System.Linq;

namespace Exercise7
{
    public class Square : IShape
    {
        private readonly Point[] _points = new Point[2];

        public Square(Point point1, Point point2)
        {
            _points[0] = point1;
            _points[1] = point2;
        }

        public int X
        {
            get
            {
                return _points.Min(point => point.X);
            }
        }

        public int Y
        {
            get
            {
                return _points.Min(point => point.Y);
            }
        }

        public int Side
        {
            get
            {
                return Math.Max(_points.Max(point => point.Y) - Y, _points.Max(point => point.X) - X);
            }
        }

        public virtual Point this[int index]
        {
            get
            {
                return _points[index];
            }
            set
            {
                if (index < 0 || index > 1) throw new IndexOutOfRangeException();
                _points[index] = value;
            }
        }

        public bool IsValid()
        {
            if (_points[0].X == _points[1].X || _points[0].Y == _points[1].Y) return true;
            if (_points.Max(point => point.X) - X == _points.Max(point => point.Y) - Y) return true;
            return false;
        }

        public double ComputeArea()
        {
            return Math.Pow(Side, 2);
        }
    }
}