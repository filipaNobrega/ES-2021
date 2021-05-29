namespace InsuranceSystem
{
    public interface IValidator
    {
        void SetNext(IValidator next);
        object Validate(object request);
    }
}