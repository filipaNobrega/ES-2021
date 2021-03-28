using System;

namespace BankSystem
{
    public class Transaction
    {
        public double Amount { get; }
        public DateTime Date { get; }
        public string Description { get; }

        public Transaction(double amount, DateTime date, string description)
        {
            Amount = amount;
            Date = date;
            Description = description;
        }
    }
}