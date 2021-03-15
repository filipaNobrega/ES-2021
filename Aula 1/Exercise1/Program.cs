using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Enter 10 integers:");
            for (var i = 1; i <= 10;)
            {
                Console.Write("{0} => ", i);

                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    sum += value;
                    i++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer:");
                }
            }

            Console.WriteLine("Total: {0}", sum);
            Console.WriteLine("Average: {0}", sum / 10.0);

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
