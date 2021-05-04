using System;

namespace UniHouse.SecondVersion
{
    // @source Breaking News: Objectville Diner and Objectville Pancake House Merge (from Head First Design Pattens book)
    class Program
    {
        static void Main(string[] args)
        {
            var dinerMenu = new DinerMenu();
            var pancakeHouseMenu = new PancakeHouseMenu();

            Console.WriteLine("Welcome to Family House");
            var waitress = new Waitress(dinerMenu, pancakeHouseMenu);

            Console.WriteLine("\nMENU");
            waitress.PrintMenu();

            Console.WriteLine("\nBREAKFAST MENU");
            waitress.PrintBreakfastMenu();

            Console.WriteLine("\nLUNCH MENU");
            waitress.PrintLunchMenu();

            Console.WriteLine("\nVEGETARIAN MENU");
            waitress.PrintVegetarianMenu();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
