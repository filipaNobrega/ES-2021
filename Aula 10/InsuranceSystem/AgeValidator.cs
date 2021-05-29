using System;

namespace InsuranceSystem
{
    public class AgeValidator : BaseValidator
    {
        public override object Validate(object request)
        {
            if (request is Application application)
            {
                if (application.Age < 18 || application.Age > 80)
                {
                    Console.WriteLine($"Invalid application! Not allowed for age: {application.Age}");

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