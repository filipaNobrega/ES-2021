using System;

namespace Logging
{
    public class DateDecorator : RecorderDecorator
    {
        public DateDecorator(IRecorder decoratedRecorder) : base(decoratedRecorder)
        {
        }

        public override void Record(string message)
        {
            var dateInfo = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToLongTimeString();
            DecoratedRecorder.Record($"{dateInfo} : {message}");
        }
    }
}