using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, and then press Enter:");
            int number1;
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Please enter a valid integer:");
            }

            Console.WriteLine("Enter another number, and then press Enter:");
            int number2;
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Please enter a valid integer:");
            }
            
            if (number2 > number1)
            {
                Console.WriteLine($"{number2} is bigger than {number1}");
            } else if (number1 > number2)
            {
                Console.WriteLine($"{number1} is bigger than {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is equal to {number2}");
            }
            
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
