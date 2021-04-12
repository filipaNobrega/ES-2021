using System.Collections.Generic;
using PizzaStore;

namespace AmericanPizzaStore
{
    public class NewYorkPizza : Pizza
    {
        public NewYorkPizza(IList<string> toppings) : base(toppings)
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