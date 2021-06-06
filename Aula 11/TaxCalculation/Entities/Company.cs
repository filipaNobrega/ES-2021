using System;
using System.Collections.Generic;

namespace TaxCalculation.Entities
{
    public class Company : TaxPayer
    {
        private readonly List<Person> _employees = new List<Person>();

        public Company()
        {
            var random = new Random();
            var count = random.NextDouble() * 100;
            for (int i = 0; i < count; i++)
            {
                Add(new Person());
            }
        }

        public void Add(Person employee)
        {
            if ( _employees.Contains(employee) ) return;

            _employees.Add(employee);
        }

        public void Remove(Person employee)
        {
            if( !_employees.Contains(employee) ) return;

            _employees.Remove(employee);
        }

        public Person this[int index]
        {
            get
            {
                return _employees[index];
            }
        }

        public int Size
        {
            get { return _employees.Count; }
        }
    }
}