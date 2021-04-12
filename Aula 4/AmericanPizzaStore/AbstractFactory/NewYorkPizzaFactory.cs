using System.Collections.Generic;
using PizzaStore;
using PizzaStore.AbstractFactory;

namespace AmericanPizzaStore.AbstractFactory
{
    public class NewYorkPizzaFactory : IPizzaFactory
    {
        public IPizza CreatePizza(IList<string> toppings)
        {
            return new NewYorkPizza(toppings);
        }
    }
}