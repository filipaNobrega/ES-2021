using System.Collections.Generic;
using Christmas.Patterns;

namespace Christmas.Entities
{
    public class Receiver : ISubject
    {
        public event UpdateEventHandler OnUpdate;

        public Receiver()
        {
            Gifts = new List<Gift>();
        }

        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnUpdate?.Invoke(this, nameof(Name));
            }
        }

        public ICollection<Gift> Gifts { get; }

        public override string ToString() => Name;
    }
}