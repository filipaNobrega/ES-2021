using AmericanPizzaStore;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmericanPizzaStoreTests
{
    [TestClass]
    public class PizzaOrderDriverServiceTests
    {
        [TestMethod]
        public void PizzaOrderDriverService_Global_Access_Same_Instance()
        {
            var instance1 = PizzaOrderDriverService.Instance;
            var instance2 = PizzaOrderDriverService.Instance;

            instance1.Should().BeSameAs(instance2);
        }
    }
}