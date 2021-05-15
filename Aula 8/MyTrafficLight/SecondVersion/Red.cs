namespace MyTrafficLight.SecondVersion
{
    public class Red : IState
    {
        private readonly TrafficLight _trafficLight;

        public Red(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Tick()
        {
            _trafficLight.SetState(_trafficLight.GetGreenState());
        }

        public override string ToString()
        {
            return "Red";
        }
    }
}