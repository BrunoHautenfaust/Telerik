
using System;
namespace Bank_accounts.AcountTypes
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

      public void Withdraw(decimal sum)
        {
          if (sum > this.Balance)
          {
              throw new ArgumentException("Overdraft is not allowed!");
          }
            this.Balance -= sum;
            System.Console.WriteLine("---> {0} lv. have been withdrawn.", sum);
        }

        public override decimal CalculateInterestRateForAGivenPeriod(int months)
        {
            decimal result = 0;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                this.InterestRate = 0;
            }
            return result = months * this.InterestRate;
        }

    }
}
