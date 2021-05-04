namespace CurrencyCalculator.LastVersion
{
    public class Subject : ISubject
    {
        public event UpdateEventHandler OnUpdate;

        public void Notify(object data)
        {
            if(OnUpdate == null) return;
            OnUpdate(this, data);
        }

        public void Notify(ISubject subject, object data)
        {
            if (OnUpdate == null) return;
            OnUpdate(subject, data);
        }
    }
}