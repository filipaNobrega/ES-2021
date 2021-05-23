namespace Logging
{
    public abstract class RecorderDecorator : IRecorder
    {
        protected RecorderDecorator(IRecorder decoratedRecorder)
        {
            DecoratedRecorder = decoratedRecorder;
        }

        protected IRecorder DecoratedRecorder { get; }

        public abstract void Record(string message);
    }
}