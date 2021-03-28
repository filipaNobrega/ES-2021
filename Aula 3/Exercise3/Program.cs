using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, and then press Enter:");
            double number1;
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Please enter a valid double:");
            }

            Console.WriteLine("Enter another number, and then press Enter:");
            double number2;
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Please enter a valid double:");
            }

            Console.WriteLine($"{number1} raised to {number2} is: {Math.Pow(number1, number2)}");
        }
    }
}
