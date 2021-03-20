using System;
using System.Text;

namespace Logging
{
    public abstract class BaseLogger : ILogger
    {
        private readonly IClock _clock;

        protected BaseLogger(IClock clock)
        {
            _clock = clock;
        }

        protected abstract string Name { get; }

        public virtual void Log(LogLevel logLevel, Exception exception)
        {
            WriteMessage(logLevel, null, exception);
        }

        public virtual void Log(LogLevel logLevel, string message, params object[] args)
        {
            WriteMessage(logLevel, string.Format(message, args), null);
        }

        protected abstract void WriteMessage(LogLevel logLevel, string message, Exception exception);

        protected virtual string GetMessage(LogLevel logLevel, string message, Exception exception)
        {
            var logBuilder = new StringBuilder();
            var logLevelString = GetLogLevelString(logLevel);
            logBuilder.Append(_clock.Now.ToString("yyyy-MM-dd HH:mm:ss,fff"));
            logBuilder.Append(" ");
            logBuilder.Append(logLevelString);
            logBuilder.Append(" " + Name + ": ");

            if (!string.IsNullOrEmpty(message)) logBuilder.Append(message);

            if (exception != null) logBuilder.Append(exception);

            return logBuilder.ToString();
        }

        protected virtual string GetLogLevelString(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Trace => "TRACE",
                LogLevel.Debug => "DEBUG",
                LogLevel.Information => "INFO",
                LogLevel.Warning => "WARN",
                LogLevel.Error => "ERROR",
                LogLevel.Critical => "FATAL",
                _ => throw new ArgumentOutOfRangeException(nameof(logLevel))
            };
        }
    }
}