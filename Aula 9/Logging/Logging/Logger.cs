namespace Logging
{
    public sealed class Logger : ILogger
    {
        public IRecorder Recorder { get; set; }

        public void Log(string message)
        {
            Recorder?.Record(message);
        }

        #region Singleton - usage: Logger.Instance

        private Logger()
        {
        }

        public static Logger Instance { get; } = new Logger();

        #endregion
    }
}