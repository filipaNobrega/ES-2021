using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Exercise7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Drawing.Rectangle a = new System.Drawing.Rectangle(1, 17, 12, 4);

            var shapes = LoadShapes(args[0]);

            var area = 0.0;
            foreach (var shape in shapes)
            {
                if (!shape.IsValid())
                {
                    Console.WriteLine("Shape is invalid!");
                    continue;
                }

                area += shape.ComputeArea();
            }

            Console.WriteLine($"Total Area: {area}");
            Console.ReadKey();
        }

        private static IEnumerable<IShape> LoadShapes(string filename)
        {
            var shapes = new List<IShape>();
            try
            {
                var file = new StreamReader(filename);
                for (var line = file.ReadLine(); line != null; line = file.ReadLine())
                {
                    if (string.IsNullOrEmpty(line) || line[0] == '!') continue;

                    var values = line.Split(',');

                    IShape shape;
                    switch (values.Length)
                    {
                        case 8:
                            shape = ReadRectangle(values);
                            break;
                        case 6:
                            shape = ReadTriangle(values);
                            break;
                        case 4:
                            shape = ReadSquare(values);
                            break;
                        case 3:
                            shape = ReadCircle(values);
                            break;
                        default:
                            shape = null;
                            break;
                    }

                    if (shape != null) shapes.Add(shape);
                }

                file.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            return shapes;
        }

        private static IShape ReadSquare(string[] values)
        {
            Debug.Assert(values.Length == 2);
            Console.WriteLine("Reading a Square...");

            if (!Point.TryParse(values[0], values[1], out var p1)) return null;

            if (!Point.TryParse(values[2], values[3], out var p2)) return null;

            return new Square(p1, p2);
        }

        private static IShape ReadCircle(string[] values)
        {
            Debug.Assert(values.Length == 3);
            Console.WriteLine("Reading a Circle...");

            if (!Point.TryParse(values[0], values[1], out var center)) return null;

            if (!int.TryParse(values[2], out var radius)) return null;

            return new Circle(center, radius);
        }

        private static IShape ReadTriangle(string[] values)
        {
            Debug.Assert(values.Length == 6);
            Console.WriteLine("Reading a Triangle...");

            if (!Point.TryParse(values[0], values[1], out var p1)) return null;

            if (!Point.TryParse(values[2], values[3], out var p2)) return null;

            if (!Point.TryParse(values[4], values[5], out var p3)) return null;

            return new Triangle(p1, p2, p3);
        }

        private static IShape ReadRectangle(string[] values)
        {
            Debug.Assert(values.Length == 8);
            Console.WriteLine("Reading a Rectangle...");

            if (!Point.TryParse(values[0], values[1], out var p1)) return null;

            if (!Point.TryParse(values[2], values[3], out var p2)) return null;

            if (!Point.TryParse(values[4], values[5], out var p3)) return null;

            if (!Point.TryParse(values[6], values[7], out var p4)) return null;

            return new Rectangle(p1, p2, p3, p4);
        }
    }
}