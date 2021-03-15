using System;
using System.Linq;

namespace Exercise7
{
    public class Rectangle : IShape
    {
        private readonly Point[] _points = new Point[4];

        public Rectangle(Point point1, Point point2, Point point3, Point point4)
        {
            _points[0] = point1;
            _points[1] = point2;
            _points[2] = point3;
            _points[3] = point4;
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

        public int Width
        {
            get
            {
                return _points.Max(point => point.X) - X;
            }
        }

        public int Height
        {
            get
            {
                return _points.Max(point => point.Y) - Y;
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
                if (index < 0 || index > 3) throw new IndexOutOfRangeException();
                _points[index] = value;
            }
        }

        public bool IsValid()
        {
            if (_points[0].X != X || _points[0].Y != Y) return false;
            if (_points[1].X != X + Width || _points[1].Y != Y) return false;
            if (_points[2].X != X + Width || _points[2].Y != Y + Height) return false;
            if (_points[3].X != X || _points[3].Y != Y + Height) return false;
            return true;
        }

        public double ComputeArea()
        {
            return Width * Height;
        }
    }
}