using System.Collections.Generic;

namespace PizzaStore
{
    public enum DoughType
    {
        None,
        Tin,
        Pan,
        DeepDish
    }

    public interface IPizza
    {
        IList<string> Toppings { get; }
        DoughType Dough { get; set; }
        string Sauce { get; set; }
        string Seasonings { get; set; }
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }

    public abstract class Pizza : IPizza
    {
        protected Pizza(IList<string> toppings)
        {
            Toppings = toppings;
        }

        public IList<string> Toppings { get; }
        public DoughType Dough { get; set; }
        public string Sauce { get; set; }
        public string Seasonings { get; set; }
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }
}