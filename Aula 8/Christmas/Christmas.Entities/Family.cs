using System.Collections.Generic;

namespace Christmas.Entities
{
    public class Family : Receiver
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public ICollection<Person> Members { get; }
    }
}