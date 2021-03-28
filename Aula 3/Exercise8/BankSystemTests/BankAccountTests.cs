using System;
using BankSystem;
using FluentAssertions;
using NUnit.Framework;

namespace BankSystemTests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void Debit_Should_Throw_ArgumentOutOfRangeException_When_Amount_Is_Bigger_Than_Balance()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            Action action = () => { bankAccount.Debit(600.00, DateTime.Now, "Debit operation fail!"); };
            action.Should().Throw<ArgumentOutOfRangeException>()
                .Where(m => m.Message.Contains("Debit amount exceeds balance!"));
        }

        [Test]
        public void Debit_Should_Throw_ArgumentOutOfRangeException_When_Amount_Is_Less_Than_Zero()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            Action action = () => { bankAccount.Debit(-10, DateTime.Now, "Debit operation fail!"); };
            action.Should().Throw<ArgumentOutOfRangeException>()
                .Where(m => m.Message.Contains("Debit amount is less than zero!"));
        }

        [Test]
        public void Debit_Should_Subtract_Amount_From_Balance()
        {
            var bankAccount = new BankAccount("alpha", 500.54); 
            bankAccount.Debit(50.54, DateTime.Now, "Electricity payment");
            bankAccount.Balance.Should().Be(450.00);
        }

        [Test]
        public void Credit_Should_Throw_ArgumentOutOfRangeException_When_Amount_Is_Less_Than_Zero()
        {
            var bankAccount = new BankAccount("alpha", 500.54);
            Action action = () => { bankAccount.Credit(-10, DateTime.Now, "Credit operation fail!"); };
            action.Should().Throw<ArgumentOutOfRangeException>()
                .Where(m => m.Message.Contains("Credit amount must be positive!"));
        }

        [Test]
        public void Credit_Should_Add_Amount_To_Balance()
        {
            var bankAccount = new BankAccount("alpha", 500.00);
            bankAccount.Credit(50.00, DateTime.Now, "PizzaHut share bill");
            bankAccount.Balance.Should().Be(550.00);
        }

        [Test]
        public void GetAccountHistory_Should_Return_Report_About_All_Transactions()
        {
            var bankAccount = new BankAccount("alpha", 500.00);
            bankAccount.Debit(50.00, new DateTime(2018, 10, 5), "Electricity payment");
            bankAccount.Credit(50.00, new DateTime(2018, 11, 1), "PizzaHut share bill");

            var result = bankAccount.GetAccountHistory();
            result.Should().Be("Date\t\tAmount\tBalance\tDescription\r\n10/5/2018\t-50\t450\tElectricity payment\r\n11/1/2018\t50\t500\tPizzaHut share bill\r\n");
        }
    }
}