using System.Collections.Generic;
using PizzaStore;

namespace AmericanPizzaStore.FactoryMethod
{
    public class CaliforniaPizzaStore : PizzaStore.FactoryMethod.PizzaStore
    {
        public override IPizza CreatePizza(IList<string> toppings)
        {
            return new CaliforniaPizza(toppings);
        }
    }
}