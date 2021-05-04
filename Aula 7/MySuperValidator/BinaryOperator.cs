namespace MySuperValidator
{
    public abstract class BinaryOperator : IValidator
    {
        protected BinaryOperator(IValidator left, IValidator right)
        {
            Left = left;
            Right = right;
        }

        protected IValidator Left { get; }
        protected IValidator Right { get; }
        public abstract bool IsValid(string value);
    }
}