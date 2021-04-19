namespace CoffeeShop.Decorators
{
    public class SoyDecorator : CondimentDecorator
    {
        public SoyDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return $"{DecoratedCoffee.GetDescription()}, Soy";
        }

        public override double GetCost()
        {
            return 0.15 + DecoratedCoffee.GetCost();
        }
    }
}