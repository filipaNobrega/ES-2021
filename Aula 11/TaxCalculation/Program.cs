using System;
using TaxCalculation.Entities;
using TaxCalculation.Visitor;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ITaxPayer person = new Person();
                ITaxPayer company = new Company();
                ITaxPayer region = new Region();

                IFriendlyIrs vanillaTaxes = new VanillaTaxes();
                IFriendlyIrs becauseWeCare = new BecauseWeCare();

                Console.WriteLine("Taxes - Vanilla Taxes - Person: " + vanillaTaxes.Tax(person));
                Console.WriteLine("Taxes - Vanilla Taxes - Company: " + vanillaTaxes.Tax(company));
                Console.WriteLine("Taxes - Vanilla Taxes - Region: " + vanillaTaxes.Tax(region));
                
                Console.WriteLine("Taxes - Because We Care - Person: " + becauseWeCare.Tax(person));
                Console.WriteLine("Taxes - Because We Care - Company: " + becauseWeCare.Tax(company));
                Console.WriteLine("Taxes - Because We Care - Region: " + becauseWeCare.Tax(region));

                Console.WriteLine("\nPlease press any key to continue or ESC to exit...");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
