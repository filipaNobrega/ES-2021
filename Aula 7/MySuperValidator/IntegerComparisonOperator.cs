namespace MySuperValidator
{
    public abstract class IntegerComparisonOperator : IValidator
    {
        protected IntegerComparisonOperator(int reference)
        {
            Reference = reference;
        }

        protected int Reference { get; }

        public abstract bool IsValid(string value);
    }
}