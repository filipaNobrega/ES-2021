namespace CoffeeShop.Decorators
{
    public class WhipDecorator : CondimentDecorator
    {
        public WhipDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return $"{DecoratedCoffee.GetDescription()}, Whip";
        }

        public override double GetCost()
        {
            return 0.10 + DecoratedCoffee.GetCost();
        }
    }
}