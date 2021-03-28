using System;

namespace Exercise5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for (var i = 1; i <= 5;)
            {
                Console.Write("{0} => ", i);

                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    array[i - 1] = value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer:");
                }
            }

            Console.WriteLine("Enter a number to search for, and then press Enter:");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number)) Console.WriteLine("Please enter a valid integer:");

            var indexOf = Array.IndexOf(array, number);
            if (indexOf < 0)
            {
                Console.WriteLine($"The number {number} was not found!");
            }
            else
            {
                Console.WriteLine($"The number {number} was found at {indexOf}!");
            }
        }
    }
}