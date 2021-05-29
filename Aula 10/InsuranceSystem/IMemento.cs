using System;

namespace InsuranceSystem
{
    public interface IMemento
    {
        string GetStatus();
        DateTime GetDate();
    }
}