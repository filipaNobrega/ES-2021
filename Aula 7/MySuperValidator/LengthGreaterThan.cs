namespace MySuperValidator
{
    public class LengthGreaterThan : IntegerComparisonOperator
    {
        public LengthGreaterThan(int reference) : base(reference)
        {
        }

        public override bool IsValid(string value)
        {
            return value.Length > Reference;
        }
    }
}