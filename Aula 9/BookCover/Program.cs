using System;

namespace BookCover
{
    class Program
    {
        static void Main(string[] args)
        {
            var spiralBinding = new SpiralBinding();

            var fantasyBook = new FantasyBook("My fantasy book", "Patrick", spiralBinding);
            Console.WriteLine(fantasyBook);
            
            var fictionBook = new FantasyBook("My fiction book", "Patrick", spiralBinding);
            Console.WriteLine(fictionBook);
        }
    }
}
