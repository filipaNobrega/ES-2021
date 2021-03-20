using System;
using System.IO;
using FluentAssertions;
using Logging;
using NSubstitute;
using NUnit.Framework;

namespace LoggingTests
{
    [TestFixture]
    public class ConsoleLoggerTests
    {
        private IClock _clock;
        private ConsoleLogger _consoleLogger;

        [SetUp]
        public  void Setup()
        {
            _clock = Substitute.For<IClock>();
            _consoleLogger = new ConsoleLogger(_clock);
        }

        [Test]
        public void Log_Debug_Message_Logs_To_Console()
        {
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                _clock.Now.Returns(new DateTime(2020, 03, 13, 17, 41, 28));
                _consoleLogger.Log(LogLevel.Debug, "This is a debug message!");

                var result = writer.ToString().Trim();
                result.Should().Be("2020-03-13 17:41:28,000 DEBUG ConsoleLogger: This is a debug message!");
            }
        }

        [Test]
        public void Log_Warning_Message_Logs_To_Console()
        {
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                _clock.Now.Returns(new DateTime(2018, 10, 22, 11, 10, 44, 678));
                _consoleLogger.Log(LogLevel.Warning, "This is a {0} message!", "warning");

                var result = writer.ToString().Trim();
                result.Should().Be("2018-10-22 11:10:44,678 WARN ConsoleLogger: This is a warning message!");
            }
        }

        [Test]
        public void Log_Critical_Exception_Logs_To_Console()
        {
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                _clock.Now.Returns(new DateTime(2018, 10, 22, 11, 10, 44, 678));
                _consoleLogger.Log(LogLevel.Critical, new Exception("This is an exception!"));

                var result = writer.ToString().Trim();
                result.Should().Be("2018-10-22 11:10:44,678 FATAL ConsoleLogger: System.Exception: This is an exception!");
            }
        }
    }
}