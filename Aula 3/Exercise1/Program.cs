using System;

namespace Exercise1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table\r");
            Console.WriteLine("----------------------------------------------------------------------\n");

            Console.WriteLine("Enter a number, and then press Enter:");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 10)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 10:");
            }

            for (var i = 1; i <= 10; i++) Console.WriteLine($"{number} * {i} = {number * i}");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}