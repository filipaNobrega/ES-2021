using System;

namespace MyTrafficLight.SecondVersion
{
    public class TrafficLight
    {
        private readonly IState _greenState;
        private readonly IState _redState;
        private readonly IState _yellowState;

        private IState _state;

        public TrafficLight()
        {
            _redState = new Red(this);
            _greenState = new Green(this);
            _yellowState = new Yellow(this);

            _state = _redState;
        }

        public IState GetRedState()
        {
            return _redState;
        }

        public IState GetGreenState()
        {
            return _greenState;
        }

        public IState GetYellowState()
        {
            return _yellowState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }
        
        public void Tick()
        {
            Console.Write($"\n[{_state}] --(tick)-> ");
            _state.Tick();
            Console.Write($"[{_state}]");
        }
    }
}