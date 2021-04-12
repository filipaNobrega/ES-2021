using System.Collections.Generic;

namespace AmericanPizzaStore
{
    public sealed class PizzaOrderDriverService
    {
        private static PizzaOrderDriverService _instance;
        private static readonly object SyncLock = new object();
        private readonly IList<string> _drivers = new List<string> {"Sue", "Tomas", "Ana", "Maria", "John"};
        private int _currentIndex;

        public PizzaOrderDriverService() { }

        public static PizzaOrderDriverService Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new PizzaOrderDriverService();
                    }
                }
                return _instance;
            }
        }

        public string GetAvailableDriver()
        {
            var result = _drivers[_currentIndex];
            
            if (_currentIndex >= _drivers.Count - 1)
            {
                _currentIndex = 0;
            }
            else
            {
                _currentIndex++;
            }

            return result;
        }
    }
}