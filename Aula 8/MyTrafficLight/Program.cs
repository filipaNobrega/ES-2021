using System;

namespace MyTrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("TRAFFIC LIGHT STATE MACHINE");

            var light = new PoorImplementation.TrafficLight();
            light.Tick();
            light.Tick();
            light.Tick();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
