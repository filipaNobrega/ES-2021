using System;

namespace Logging.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var composedRecorder = new ComposedRecorder();
            composedRecorder.Add(new DateDecorator(new FileRecorder("logOutputFile.txt")));
            composedRecorder.Add(new DateDecorator(new CounterDecorator(new ConsoleRecorder())));
            composedRecorder.Add(new TraceRecorder());

            // Set Recorder to use ComposedRecorder
            Logger.Instance.Recorder = composedRecorder;
            
            Logger.Instance.Log("Test");
        }
    }
}
