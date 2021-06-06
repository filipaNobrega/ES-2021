using TaxCalculation.Visitor;

namespace TaxCalculation.Entities
{
    public abstract class TaxPayer : ITaxPayer
    {
        public double Accept(IFriendlyIrs irs)
        {
            return irs.Tax(this);
        }
    }
}