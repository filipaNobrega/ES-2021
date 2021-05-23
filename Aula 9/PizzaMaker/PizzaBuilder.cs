namespace PizzaMaker
{
    public class PizzaBuilder
    {
        public PizzaBuilder(Size size, DoughType doughType = DoughType.Tin)
        {
            Size = size;
            DoughType = doughType;
        }

        public Size Size { get;  }
        public Cheese Cheese { get; private set; }
        public DoughType DoughType { get; }
        public bool HasSauce { get; private set; }
        public bool HasPepperoni { get; private set; }
        public bool HasOlives { get; private set; }
        public bool HasMushrooms { get; private set; }
        public bool HasCorn { get; private set; }

        public PizzaBuilder AddSauce()
        {
            HasSauce = true;
            return this;
        }

        public PizzaBuilder AddCheese(Cheese cheese = Cheese.Mozzarella)
        {
            Cheese = cheese;
            return this;
        }

        public PizzaBuilder AddOlives()
        {
            HasOlives = true;
            return this;
        }

        public PizzaBuilder AddCorn()
        {
            HasCorn = true;
            return this;
        }
        public PizzaBuilder AddMushrooms()
        {
            HasMushrooms = true;
            return this;
        }

        public PizzaBuilder AddPeperoni()
        {
            HasPepperoni = true;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(this);
        }
    }
}