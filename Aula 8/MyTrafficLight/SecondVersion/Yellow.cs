namespace MyTrafficLight.SecondVersion
{
    public class Yellow : IState
    {
        private readonly TrafficLight _trafficLight;

        public Yellow(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Tick()
        {
            _trafficLight.SetState(_trafficLight.GetRedState());
        }

        public override string ToString()
        {
            return "Yellow";
        }
    }
}