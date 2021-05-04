namespace MySuperValidator
{
    public abstract class UnaryOperator : IValidator
    {
        protected UnaryOperator(IValidator validator)
        {
            Validator = validator;
        }

        protected IValidator Validator { get; }

        public abstract bool IsValid(string value);
    }
}