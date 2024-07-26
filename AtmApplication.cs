using System;
using System.Collections.Generic;

namespace KaranPreetAssignment3
{
    public class AtmApplication
    {
        private Bank bank;
        private Account currentAccount;

        public AtmApplication()
        {
            bank = new Bank();
        }

        public void CreateAccount(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
        {
            bank.AddAccount(new Account(accountNumber, initialBalance, interestRate, accountHolderName));
        }

        public Account SelectAccount(int accountNumber)
        {
            currentAccount = bank.GetAccount(accountNumber);
            return currentAccount;
        }

        public double CheckBalance()
        {
            if (currentAccount != null)
            {
                return currentAccount.GetBalance();
            }
            throw new InvalidOperationException("No account selected.");
        }

        public void Deposit(double amount)
        {
            if (currentAccount != null)
            {
                currentAccount.Deposit(amount);
            }
            else
            {
                throw new InvalidOperationException("No account selected.");
            }
        }

        public bool Withdraw(double amount)
        {
            if (currentAccount != null)
            {
                return currentAccount.Withdraw(amount);
            }
            throw new InvalidOperationException("No account selected.");
        }

        public List<string> GetTransactions()
        {
            if (currentAccount != null)
            {
                return currentAccount.GetTransactions();
            }
            throw new InvalidOperationException("No account selected.");
        }

        public void ExitAccount()
        {
            currentAccount = null;
        }
    }
}
