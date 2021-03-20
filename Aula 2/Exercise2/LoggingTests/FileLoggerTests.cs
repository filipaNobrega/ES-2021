using System;
using System.IO;
using FluentAssertions;
using Logging;
using NSubstitute;
using NUnit.Framework;

namespace LoggingTests
{
    [TestFixture]
    public class FileLoggerTests
    {
        private IClock _clock;
        private IFileSystem _fileSystem;
        private FileLogger _fileLogger;

        [SetUp]
        public void Setup()
        {
            _clock = Substitute.For<IClock>();
            _fileSystem = Substitute.For<IFileSystem>();
            _fileLogger = new FileLogger(_clock, _fileSystem) {File = "C:\\FakeFolder\\log.txt"};
        }

        [Test]
        public void Log_Info_Message_Delegates_To_File_System()
        {
            _clock.Now.Returns(new DateTime(2020, 03, 13, 17, 41, 28));

            _fileLogger.Log(LogLevel.Information, "This is a info message!");
            
            _fileSystem.Received(1).WriteLine("C:\\FakeFolder\\log.txt", "2020-03-13 17:41:28,000 INFO FileLogger: This is a info message!");
        }

        [Test]
        public void Log_Error_Exception_Delegates_To_File_System()
        {
            _clock.Now.Returns(new DateTime(2018, 10, 22, 11, 10, 44, 678));

            _fileLogger.Log(LogLevel.Error, new Exception("This is an exception!"));

            _fileSystem.Received(1).WriteLine("C:\\FakeFolder\\log.txt", "2018-10-22 11:10:44,678 ERROR FileLogger: System.Exception: This is an exception!");
        }
    }
}