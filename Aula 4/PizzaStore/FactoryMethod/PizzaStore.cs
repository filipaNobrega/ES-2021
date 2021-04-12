using System.Collections.Generic;

namespace PizzaStore.FactoryMethod
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(IList<string> toppings)
        {
            var pizzaForDelivery = CreatePizza(toppings);
            pizzaForDelivery.Prepare();
            pizzaForDelivery.Bake();
            pizzaForDelivery.Cut();
            pizzaForDelivery.Box();
            return pizzaForDelivery;
        }

        public abstract IPizza CreatePizza(IList<string> toppings);
    }
}