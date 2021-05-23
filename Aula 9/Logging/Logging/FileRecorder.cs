using System;
using System.IO;

namespace Logging
{
    public class FileRecorder : IRecorder, IDisposable
    {
        private readonly StreamWriter _stream;
        public FileRecorder(string filename)
        {
            _stream = new StreamWriter(filename) {AutoFlush = true};
        }

        public void Record(string message)
        {
            _stream.WriteLine(message);
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }
    }
}