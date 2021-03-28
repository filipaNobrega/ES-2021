using System;

namespace Exercise6
{
    class Program
    {
        private const int MinimumAge = 25;
        private const double AgePercentage = 0.01;
        private const int MinimumYearsOfService = 6;
        private const double YearsOfServicePercentage = 0.03;
        private const int MaximumNumberOfChildren = 4;
        private const double NumberOfChildrenPercentage = 0.05;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the base salary (VB):");
            double salary;
            while (!double.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Please enter a valid integer:");
            }

            Console.WriteLine("Please enter your employee's age (Id):");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Please enter a valid integer:");
            }

            Console.WriteLine("Please enter the total number of children (NF):");
            int numberOfChildren;
            while (!int.TryParse(Console.ReadLine(), out numberOfChildren))
            {
                Console.WriteLine("Please enter a valid integer:");
            }

            Console.WriteLine("Please enter the total number of years working for the company (AS):");
            int yearsOfService;
            while (!int.TryParse(Console.ReadLine(), out yearsOfService))
            {
                Console.WriteLine("Please enter a valid integer:");
            }

            double total = salary;
            if (age > MinimumAge)
            {
                total += total * (age - MinimumAge) * AgePercentage;
            }
            if (yearsOfService > MinimumYearsOfService)
            {
                total += total * yearsOfService * YearsOfServicePercentage;
            }
            if (numberOfChildren > 0)
            {
                total += total * Math.Min(numberOfChildren, MaximumNumberOfChildren) * NumberOfChildrenPercentage;
            }

            Console.WriteLine($"Total: {total}");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
