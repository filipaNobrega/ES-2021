using System;

namespace UniHouse.LastVersion
{
    public class Waitress
    {
        private readonly IMenuComponent _root;

        public Waitress(IMenuComponent root)
        {
            _root = root;
        }

        public void PrintMenu()
        {
            Console.Write(_root.ToString());
        }
    }
}