using System;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceSystem
{
    public class ConcreteMemento : IMemento
    {
        private readonly ApplicationList _current;
        private readonly DateTime _currentDate;

        public ConcreteMemento(ApplicationList current)
        {
            _current = (ApplicationList) current.Clone();
            _currentDate = DateTime.UtcNow;
        }

        public string GetStatus()
        {
            return string.Join(", ", _current.Select(a => $"{a.Name} {a.Surname}"));
        }

        public DateTime GetDate()
        {
            return _currentDate;
        }
    }
}