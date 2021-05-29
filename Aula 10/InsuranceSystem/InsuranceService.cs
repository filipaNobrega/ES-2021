using System;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceSystem
{
    public class InsuranceService
    {
        private readonly IValidator _validator;
        private readonly ApplicationList _applications = new ApplicationList();

        public InsuranceService(IValidator validator)
        {
            _validator = validator;
        }

        public IEnumerable<Application> GetAll()
        {
            return _applications;
        }

        public void Insert(Application application)
        {
            if( _applications.Contains(application) ) return;

            _applications.Add(application);
        }

        public void Delete(Application application)
        {
            if (!_applications.Contains(application)) return;

            _applications.Remove(application);
        }

        public void Delete(int id)
        {
            var application = _applications.SingleOrDefault(a => a.Id == id);

            if(application == null) return;

            _applications.Remove(application);
        }

        public IEnumerable<Application> GetAllValid()
        {
            var result = new List<Application>();

            foreach (var application in _applications)
            {
                var isValid = (bool) _validator.Validate(application);
                if (isValid)
                {
                    result.Add(application);
                }
            }

            return result;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(_applications);
        }
    }
}