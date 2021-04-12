using System.Collections.Generic;
using PizzaStore;

namespace AmericanPizzaStore
{
    public class ChicagoPizza : Pizza
    {
        public ChicagoPizza(IList<string> toppings) : base(toppings)
        {
            Dough = DoughType.Pan;
        }

        public override void Prepare()
        {
        }

        public override void Bake()
        {
        }

        public override void Cut()
        {
        }

        public override void Box()
        {
        }
    }
}