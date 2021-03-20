using System;

namespace Logging
{
    public class ConsoleLogger : BaseLogger
    {
        public ConsoleLogger(IClock clock) : base(clock)
        {
        }

        protected override string Name
        {
            get
            {
                return nameof(ConsoleLogger);
            }
        }

        protected override void WriteMessage(LogLevel logLevel, string message, Exception exception)
        {
            (Console.BackgroundColor, Console.ForegroundColor) = GetLogLevelConsoleColors(logLevel);
            var contents = GetMessage(logLevel, message, exception);
            Console.WriteLine(contents);
            Console.ResetColor();
        }

        private static (ConsoleColor, ConsoleColor) GetLogLevelConsoleColors(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Critical => (ConsoleColor.White, ConsoleColor.Red),
                LogLevel.Error => (ConsoleColor.Black, ConsoleColor.Red),
                LogLevel.Warning => (ConsoleColor.Yellow, ConsoleColor.Black),
                LogLevel.Information => (ConsoleColor.DarkGreen, ConsoleColor.Black),
                LogLevel.Debug => (ConsoleColor.Gray, ConsoleColor.Black),
                LogLevel.Trace => (ConsoleColor.DarkGray, ConsoleColor.Black),
                _ => (ConsoleColor.White, ConsoleColor.Black)
            };
        }
    }
}