
using Bank_accounts.CustomerTypes;
using System;
namespace Bank_accounts.AcountTypes
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterestRateForAGivenPeriod(int months)
        {
            decimal result = 0;
            if (this.Customer is Individual)
            {
                months = Math.Max(0, months - 3);
            }
            else if (this.Customer is Company)
            {
                months = Math.Max(0, months - 2);
            }
            return result = months * this.InterestRate;
        }
    }
}
