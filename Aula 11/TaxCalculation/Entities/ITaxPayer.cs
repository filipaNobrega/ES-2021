using TaxCalculation.Visitor;

namespace TaxCalculation.Entities
{
    public interface ITaxPayer
    {
        double Accept(IFriendlyIrs irs);
    }
}