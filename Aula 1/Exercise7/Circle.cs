using System;

namespace Exercise7
{
    public class Circle : IShape
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public Point Center { get; set; }

        public double Radius { get; set; }

        public bool IsValid()
        {
            return true;
        }

        public double ComputeArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}