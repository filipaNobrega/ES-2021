using System.Collections.Generic;

namespace CurrencyCalculator.SecondVersion
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public void Register(IObserver observer)
        {
            if(_observers.Contains(observer)) return;
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            if (!_observers.Contains(observer)) return;
            _observers.Remove(observer);
        }

        public void Notify(object data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this, data);
            }
        }

        public void Notify(ISubject subject, object data)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(subject, data);
            }
        }
    }
}