using System;

namespace TemperatureConverter
{
    public class FahrenheitTemperature : ITemperature
    {
        public FahrenheitTemperature(double degrees)
        {
            Degrees = degrees;
        }

        public double Degrees { get; }
        public double Convert()
        {
            return Math.Round((Degrees - 32) * 5 / 9, 1);
        }
    }
}