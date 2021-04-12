using System.Collections.Generic;
using PizzaStore;

namespace AmericanPizzaStore.SimpleFactory
{
    public enum PizzaType
    {
        NewYork,
        Chicago,
        California
    }

    public class SimplePizzaFactory
    {
        public static IPizza CreatePizza(PizzaType type, IList<string> toppings)
        {
            switch (type)
            {
                case PizzaType.NewYork:
                    return new NewYorkPizza(toppings);
                case PizzaType.Chicago:
                    return new ChicagoPizza(toppings);
                case PizzaType.California:
                    return new CaliforniaPizza(toppings);
                default: return null;
            }
        }
    }
}