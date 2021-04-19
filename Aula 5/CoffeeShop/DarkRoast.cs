namespace CoffeeShop
{
    public class DarkRoast : ICoffee
    {
        public string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public double GetCost()
        {
            return 0.99;
        }
    }
}