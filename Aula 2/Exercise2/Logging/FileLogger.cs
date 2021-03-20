using System;

namespace Logging
{
    public class FileLogger : BaseLogger
    {
        private readonly IFileSystem _fileSystem;

        public FileLogger(IClock clock, IFileSystem fileSystem) : base(clock)
        {
            _fileSystem = fileSystem;
        }

        public virtual string File { get; set; }

        protected override string Name
        {
            get
            {
                return nameof(FileLogger);
            }
        }

        protected override void WriteMessage(LogLevel logLevel, string message, Exception exception)
        {
            var contents = GetMessage(logLevel, message, exception);
            _fileSystem.WriteLine(File, contents);
        }
    }
}