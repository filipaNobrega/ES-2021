using System;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the total number of elements in a sequence:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Please enter a valid integer:");
            }

            var array = new int[size];
            Console.WriteLine($"Enter {size} integers:");
            for (var i = 1; i <= size;)
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

            Console.WriteLine($"The minimum value in the sequence is: {array.Min()}");
            Console.WriteLine($"The 3 max values in the sequence are: {string.Join(", ", array.OrderByDescending(i => i).Take(3))}");
            Console.WriteLine($"Average: {array.Sum() / size}");
            var totalCount = array.Count(i => i > 10);
            Console.WriteLine($"The total number of elements in the sequence bigger than 10 are: {string.Join(", ", totalCount)}");
            Console.WriteLine($"The % of the number of elements in the sequence bigger than 10 are: {totalCount * 100 / size }%");
            if (totalCount > 0)
            {
                Console.WriteLine($"Average: {array.Where(i => i > 10).Sum() / totalCount}");
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
