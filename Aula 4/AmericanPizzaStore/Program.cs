using System;

namespace AmericanPizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var host1PizzaOrderDriverService = PizzaOrderDriverService.Instance;
            Console.WriteLine("1. The driver that will take your order is: " + host1PizzaOrderDriverService.GetAvailableDriver());
            var host2PizzaOrderDriverService = PizzaOrderDriverService.Instance;
            Console.WriteLine("2. The driver that will take your order is: " + host2PizzaOrderDriverService.GetAvailableDriver());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
