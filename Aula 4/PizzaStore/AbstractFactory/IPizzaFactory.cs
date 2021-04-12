using System.Collections.Generic;

namespace PizzaStore.AbstractFactory
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(IList<string> toppings);
    }
}