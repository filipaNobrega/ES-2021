using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore;
using PizzaStore.AbstractFactory;
using NSubstitute;

namespace PizzaStoreTests.AbstractFactory
{
    [TestClass]
    public class PizzaStoreWithAbstractFactoryTests
    {
        [TestMethod]
        public void OrderPizzaTest_Delegates_To_IPizza_Preparation()
        {
            var toppings = new List<string>();

            var factory = Substitute.For<IPizzaFactory>();
            var pizzaStore = new PizzaStoreWithAbstractFactory(factory);

            var pizza = Substitute.For<IPizza>();
            factory.CreatePizza(toppings).Returns(pizza);

            pizzaStore.OrderPizza(toppings);

            Received.InOrder(() =>
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            });
        }
    }
}