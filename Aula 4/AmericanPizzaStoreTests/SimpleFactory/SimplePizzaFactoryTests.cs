using System;
using System.Collections.Generic;
using AmericanPizzaStore;
using AmericanPizzaStore.SimpleFactory;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore;

namespace AmericanPizzaStoreTests.SimpleFactory
{
    [TestClass()]
    public class SimplePizzaFactoryTests
    {

        [DataRow(PizzaType.California, typeof(CaliforniaPizza))]
        [DataRow(PizzaType.Chicago, typeof(ChicagoPizza))]
        [DataTestMethod]
        public void CreatePizzaTest(PizzaType pizzaType, Type type)
        {
            var toppings = new List<string>();
            IPizza pizza = null;
            switch (pizzaType)
            {
                case PizzaType.NewYork:
                    pizza = new NewYorkPizza(toppings);
                    break;
                case PizzaType.Chicago:
                    pizza = new ChicagoPizza(toppings);
                    break;
                case PizzaType.California:
                    pizza = new CaliforniaPizza(toppings);
                    break;
            }
            pizza.Should().BeOfType(type);
        }
    }
}