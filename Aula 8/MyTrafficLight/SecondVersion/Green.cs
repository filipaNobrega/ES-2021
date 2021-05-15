namespace MyTrafficLight.SecondVersion
{
    public class Green : IState
    {
        private readonly TrafficLight _trafficLight;

        public Green(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Tick()
        {
            _trafficLight.SetState(_trafficLight.GetYellowState());
        }

        public override string ToString()
        {
            return "Green";
        }
    }
}