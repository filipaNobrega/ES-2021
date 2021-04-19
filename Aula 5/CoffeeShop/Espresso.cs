namespace CoffeeShop
{
    public class Espresso : ICoffee
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetCost()
        {
            return 1.99;
        }
    }
}