using System;
using System.Collections.Generic;

namespace InsuranceSystem
{
    public class ApplicationList : List<Application>, ICloneable
    {
        public ApplicationList()
        {
        }

        public ApplicationList(IEnumerable<Application> collection) : base(collection)
        {
        }

        public object Clone()
        {
            return new ApplicationList(ToArray());
        }
    }
}