using System.Drawing;

namespace DrawingTool
{
    public class Flyweight
    {
        public Brush Brush { get; }

        public Flyweight(Brush brush)
        {
            Brush = brush;
        }

        public void DrawRectangle(Graphics graphics, float x, float y, float width, float height)
        {
            graphics.FillRectangle(Brush, x, y, width, height);
        }
    }
}