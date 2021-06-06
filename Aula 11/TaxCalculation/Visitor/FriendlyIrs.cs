using System;
using TaxCalculation.Entities;

namespace TaxCalculation.Visitor
{
    public abstract class FriendlyIrs : IFriendlyIrs
    {
        public double Tax(ITaxPayer payer)
        {
            switch (payer)
            {
                case Person person: return Tax(person);
                case Company company: return Tax(company);
                case Region region: return Tax(region);
                default: throw new ArgumentOutOfRangeException(nameof(payer));
            }
        }

        protected virtual double Tax(Person person)
        {
            return 1;
        }

        protected virtual double Tax(Company company)
        {
            double taxes = 0;
            for (int i = 0; i < company.Size; i++)
            {
                taxes += company[i].Accept(this);
            }
            return taxes;
        }

        protected virtual double Tax(Region region)
        {
            double taxes = 0;
            for (int i = 0; i < region.Size; i++)
            {
                taxes += region[i].Accept(this);
            }
            return taxes;
        }
    }
}