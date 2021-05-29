using System;

namespace InsuranceSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new AgeValidator();
            validator.SetNext(new PreExistingHeathConditionsValidator());

            var insuranceSvc = new InsuranceService(validator);
            var mementoHistory = new MementoHistory(insuranceSvc);

            insuranceSvc.Insert(new Application
            {
                Name = "John",
                Surname = "Smith",
                Age = 81
            });
            mementoHistory.Backup();
            
            insuranceSvc.Insert(new Application
            {
                Name = "Jess",
                Surname = "Smith",
                Age = 75,
                HasCancer = true
            });
            mementoHistory.Backup();

            insuranceSvc.Insert(new Application
            {
                Name = "Tom",
                Surname = "Smith",
                Age = 44,
                HasDiabetes = true
            });
            mementoHistory.Backup();

            var applicationToInsert = new Application
            {
                Name = "Tommy",
                Surname = "Smith",
                Age = 77,
                HasAcne = true
            };
            insuranceSvc.Insert(applicationToInsert);
            mementoHistory.Backup();

            insuranceSvc.Delete(applicationToInsert);
            mementoHistory.Backup();

            var allValid = insuranceSvc.GetAllValid();
            foreach (var application in allValid)
            {
                Console.WriteLine("Accepted: " + application.Name + " " + application.Surname);
            }

            Console.WriteLine("History:");
            mementoHistory.ShowHistory();
            
            mementoHistory.Undo();
            mementoHistory.Undo();

            Console.WriteLine("History (2 operations ago):");
            mementoHistory.ShowHistory();
        }
    }
}
