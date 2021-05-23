namespace Logging.Console
{
    public class ConsoleRecorder : IRecorder
    {
        public void Record(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}