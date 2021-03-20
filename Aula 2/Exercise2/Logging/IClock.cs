using System;

namespace Logging
{
    public interface IClock
    {
        DateTime Now { get; }
    }
}