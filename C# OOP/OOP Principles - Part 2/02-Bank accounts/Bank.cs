
using System.Collections.Generic;
using System.Text;
namespace Bank_accounts
{
   public class Bank
    {
        private List<Account> accounts;
        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public void AddAccount(Account acc)
        {
            this.accounts.Add(acc);
        }

        public void RemoveAccount(Account acc)
        {
            this.accounts.Remove(acc);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var account in this.accounts)
            {
                sb.AppendLine(account.ToString());
            }

            return sb.ToString();
        }

    }
}
