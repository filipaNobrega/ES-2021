namespace TemperatureConverter
{
    public interface ITemperature
    {
        double Degrees { get; }
        double Convert();
    }
}