using System;
using System.Collections.Generic;

namespace KaranPreetAssignment3
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }
        public double InterestRate { get; set; }
        public string AccountHolderName { get; set; }
        private List<string> transactions;

        public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
            InterestRate = interestRate;
            AccountHolderName = accountHolderName;
            transactions = new List<string>();
            AddTransaction("Account created with initial balance: " + initialBalance);
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                AddTransaction("Deposited: " + amount);
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                AddTransaction("Withdrew: " + amount);
                return true;
            }
            return false;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public List<string> GetTransactions()
        {
            return transactions;
        }

        private void AddTransaction(string transaction)
        {
            transactions.Add(transaction);
        }
    }
}
