using System;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceSystem
{
    public class MementoHistory
    {
        private readonly InsuranceService _originator;
        private readonly List<IMemento> _mementos = new List<IMemento>();

        public MementoHistory(InsuranceService originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            var memento = _originator.Save();
            _mementos.Add(memento);
        }

        public void Undo()
        {
            var last = _mementos.Last();
            _mementos.Remove(last);
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos)
            {
                Console.WriteLine($"{memento.GetDate()} : {memento.GetStatus()}");
            }
        }
    }
}