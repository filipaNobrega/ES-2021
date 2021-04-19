using System;
using CoffeeShop.Decorators;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coffee Shop!");

            Console.WriteLine("1- Espresso");
            Console.WriteLine("2- Dark Roast");
            Console.WriteLine("3- House Blend");
            Console.Write("Please select your coffee: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("!Wrong option");
            }

            ICoffee coffee;
            switch (option)
            {
                case 1:
                    coffee = new Espresso();
                    break;
                case 2:
                    coffee = new DarkRoast();
                    break;
                case 3:
                    coffee = new HouseBlend();
                    break;
                default:
                    throw new ArgumentException($"The option '{option}' does not exist!");
            }
            Console.WriteLine($"{coffee.GetDescription()} {coffee.GetCost()}");
            
            Console.WriteLine("1- Mocha");  //Mocha - 0.20 - "Espresso, Mocha"
            Console.WriteLine("2- Soy"); //Soy - 0.15
            Console.WriteLine("3- Whip"); //Whip - 0.10
            Console.WriteLine("0- No more");

            int condiment;
            do
            {
                Console.Write("Please select your condiment: ");
                while (!int.TryParse(Console.ReadLine(), out condiment))
                {
                    Console.WriteLine("!No condiment available for your selection");
                }

                switch (condiment)
                {
                    case 1:
                        coffee = new MochaDecorator(coffee);
                        break;
                    case 2:
                        coffee = new SoyDecorator(coffee);
                        break;
                    case 3:
                        coffee = new WhipDecorator(coffee);
                        break;
                    default:
                        Console.WriteLine($"!Condiment '{condiment}' does not exist");
                        break;
                }
            } while (condiment != 0);

            Console.WriteLine($"{coffee.GetDescription()} {coffee.GetCost()}");
        }
    }
}
