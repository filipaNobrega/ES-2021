namespace CoffeeShop.Decorators
{
    public abstract class CondimentDecorator : ICoffee
    {
        protected ICoffee DecoratedCoffee { get; }

        public CondimentDecorator(ICoffee coffee)
        {
            DecoratedCoffee = coffee;
        }

        public abstract string GetDescription();
        public abstract double GetCost();
    }
}