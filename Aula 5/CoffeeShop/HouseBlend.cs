namespace CoffeeShop
{
    public class HouseBlend : ICoffee
    {
        public string GetDescription()
        {
            return "House Blend Coffee";
        }

        public double GetCost()
        {
            return 0.89;
        }
    }
}