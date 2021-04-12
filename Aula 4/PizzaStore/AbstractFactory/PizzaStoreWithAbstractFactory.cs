using System.Collections.Generic;

namespace PizzaStore.AbstractFactory
{
    internal class PizzaStoreWithAbstractFactory
    {
        private readonly IPizzaFactory _factory;

        public PizzaStoreWithAbstractFactory(IPizzaFactory factory)
        {
            _factory = factory;
        }

        public IPizza OrderPizza(IList<string> toppings)
        {
            var pizzaForDelivery = _factory.CreatePizza(toppings);
            pizzaForDelivery.Prepare();
            pizzaForDelivery.Bake();
            pizzaForDelivery.Cut();
            pizzaForDelivery.Box();
            return pizzaForDelivery;
        }
    }
}