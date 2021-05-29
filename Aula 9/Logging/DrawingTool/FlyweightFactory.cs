using System.Collections.Generic;
using System.Drawing;

namespace DrawingTool
{
    public class FlyweightFactory
    {
        private static readonly Dictionary<Color, Flyweight> Cache = new Dictionary<Color, Flyweight>();

        public static Flyweight GetFlyweight(Color color)
        {
            if (Cache.ContainsKey(color))
            {
                return Cache[color];
            }

            var brush = new SolidBrush(color);
            var flyweight = new Flyweight(brush);
            Cache.Add(color, flyweight);
            return flyweight;
        }
    }
}