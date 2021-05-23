using System;

namespace PizzaMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var largePizza = new PizzaBuilder(Size.Large, DoughType.Pan).AddCheese(Cheese.Cheddar).AddSauce().AddOlives().Build();
            Console.WriteLine(largePizza);
        }
    }
}
