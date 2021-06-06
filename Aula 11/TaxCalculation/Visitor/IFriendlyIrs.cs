using TaxCalculation.Entities;

namespace TaxCalculation.Visitor
{
    public interface IFriendlyIrs
    {
        double Tax(ITaxPayer payer);
    }
}