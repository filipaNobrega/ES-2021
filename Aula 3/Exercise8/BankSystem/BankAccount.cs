using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class BankAccount
    {
        private static int _accountNumberSeed = 1234567890;
        private readonly double _initialBalance;
        private readonly IList<Transaction> _transactions = new List<Transaction>();

        public BankAccount(string name, double initialBalance)
        {
            Number = _accountNumberSeed.ToString();
            _accountNumberSeed++;
            Owner = name;
            _initialBalance = initialBalance;
            Balance = initialBalance;
        }

        public string Number { get; }

        public string Owner { get; }

        public double Balance { get; private set; }
        
        public void Debit(double amount, DateTime date, string description)
        {
            if (amount > Balance)
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Debit amount exceeds balance!");
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Debit amount is less than zero!");
            Balance -= amount;
            _transactions.Add(new Transaction(-amount, date, description));
        }

        public void Credit(double amount, DateTime date, string description)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount), "Credit amount must be positive!");
            Balance += amount;
            _transactions.Add(new Transaction(amount, date, description));
        }

        public string GetAccountHistory()
        {
            var builder = new StringBuilder();

            double balance = _initialBalance;
            builder.AppendLine("Date\t\tAmount\tBalance\tDescription");
            foreach (var transaction in _transactions)
            {
                balance += transaction.Amount;
                builder.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Description}");
            }

            return builder.ToString();
        }
    }
}
