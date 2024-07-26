using System.Collections.Generic;

namespace KaranPreetAssignment3
{
    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            // Initialize with 10 default accounts
            accounts = new List<Account>();
            for (int i = 100; i < 110; i++)
            {
                accounts.Add(new Account(i, 100, 3, $"Holder{i}"));
            }
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account GetAccount(int accountNumber)
        {
            foreach (var account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null; // or throw an exception if you prefer
        }
    }
}
