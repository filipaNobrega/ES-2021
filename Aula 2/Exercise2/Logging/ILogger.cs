using System;

namespace Logging
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, Exception exception);
        void Log(LogLevel logLevel, string message, params object[] args);
    }
}