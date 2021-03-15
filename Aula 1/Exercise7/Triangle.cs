using System.Collections.Generic;

namespace Exercise7
{
    public class Triangle : IShape
    {
        private readonly Point[] _points = new Point[3];

        public Triangle(Point point1, Point point2, Point point3)
        {
            _points[0] = point1;
            _points[1] = point2;
            _points[2] = point3;
        }
        
        public int Width
        {
            get { return _points[1].X - _points[0].X; }
        }

        public int Height
        {
            get { return _points[0].Y - _points[2].Y; }
        }

        public bool IsValid()
        {
            if (_points[0].Y != _points[1].Y) return false;
            if (_points[0].Y < _points[2].Y) return false;
            return true;
        }

        public double ComputeArea()
        {
            return Width * Height / 2.0;
        }
    }
}