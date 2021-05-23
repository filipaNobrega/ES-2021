namespace Logging
{
    public class CounterDecorator : RecorderDecorator
    {
        private int _counter;
        public CounterDecorator(IRecorder decoratedRecorder) : base(decoratedRecorder)
        {
            _counter = 0;
        }

        public override void Record(string message)
        {
            DecoratedRecorder.Record($"{++_counter} : {message}");
        }
    }
}