using System.Text;

namespace PizzaMaker
{

    public enum Cheese { Mozzarella, Cheddar }
    public enum Size { Small, Medium, Large, XLarge }
    public enum DoughType { Pan, Tin }
    public class Pizza
    {
        public Pizza(PizzaBuilder builder)
        {
            Size = builder.Size;
            Cheese = builder.Cheese;
            DoughType = builder.DoughType;
            HasSauce = builder.HasSauce;
            HasPepperoni = builder.HasPepperoni;
            HasOlives = builder.HasOlives;
            HasMushrooms = builder.HasMushrooms;
            HasCorn = builder.HasCorn;
        }

        public Size Size { get; }
        public Cheese Cheese { get; }
        public DoughType DoughType { get; }
        public bool HasSauce { get; }
        public bool HasPepperoni { get; }
        public bool HasOlives { get; }
        public bool HasMushrooms { get; }
        public bool HasCorn { get; }
        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"{Size} pizza with {Cheese} cheese and {DoughType} dough");

            if (HasSauce)
            {
                strBuilder.Append(", Sauce");
            }
            if (HasPepperoni)
            {
                strBuilder.Append(", Pepperoni");
            }
            if (HasOlives)
            {
                strBuilder.Append(", Olives");
            }

            return strBuilder.ToString();
        }
    }
}