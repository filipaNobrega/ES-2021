using System;

namespace MyTrafficLight.FirstVersion
{
    public class TrafficLight
    {
        private const int Red = 0;
        private const int Green = 1;
        private const int Yellow = 2;

        private int _state = 0;

        public void Tick()
        {
            switch (_state)
            {
                case Red:
                    Console.Write($"\n[{nameof(Red)}] --(tick)-> ");
                    _state = 1;
                    Console.Write($"[{nameof(Green)}]");
                    break;

                case Green:
                    Console.Write($"\n[{nameof(Green)}] --(tick)-> ");
                    _state = 2;
                    Console.Write($"[{nameof(Yellow)}]");
                    break;

                case Yellow:
                    Console.Write($"\n[{nameof(Yellow)}] --(tick)-> ");
                    _state = 0;
                    Console.Write($"[{nameof(Red)}]");
                    break;
            }
        }
    }
}