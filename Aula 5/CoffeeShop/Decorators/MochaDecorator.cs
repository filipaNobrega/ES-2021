namespace CoffeeShop.Decorators
{
    public class MochaDecorator : CondimentDecorator
    {
        public MochaDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return $"{DecoratedCoffee.GetDescription()}, Mocha";
        }

        public override double GetCost()
        {
            return 0.20 + DecoratedCoffee.GetCost();
        }
    }
}