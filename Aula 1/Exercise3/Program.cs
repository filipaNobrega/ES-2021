using System;

namespace Exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a number, and then press Enter: ");
            int left;
            while (!int.TryParse(Console.ReadLine(), out left)) Console.WriteLine("Please enter a valid integer:");

            Console.Write("Enter another number, and then press Enter: ");
            int right;
            while (!int.TryParse(Console.ReadLine(), out right)) Console.WriteLine("Please enter a valid integer:");
            
            Console.WriteLine("The greatest common divisor (GCD) between {0} and {1} is {2}", left, right, GreatestCommonDivisor(left, right));

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private static int GreatestCommonDivisor(int number1, int number2)
        {
            if (number1 < number2) return GreatestCommonDivisor(number2, number1);
            return number2 == 0 ? number1 : GreatestCommonDivisor(number2, number1 % number2);
        }
    }
}