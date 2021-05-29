using System;

namespace InsuranceSystem
{
    public class PreExistingHeathConditionsValidator : BaseValidator
    {
        public override object Validate(object request)
        {
            if (request is Application application)
            {
                if (application.HasCancer || application.HasEpilepsy || application.HasLupus)
                {
                    Console.WriteLine("Invalid application! Pre-existing heath conditions not allowed for this insurance plan!");
                    return false;
                }

                return base.Validate(request) ?? true;
            }
            else
            {
                throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }
        }
    }
}