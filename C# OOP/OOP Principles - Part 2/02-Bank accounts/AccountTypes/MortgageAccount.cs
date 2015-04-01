
using Bank_accounts.CustomerTypes;
using System;
namespace Bank_accounts.AcountTypes
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterestRateForAGivenPeriod(int months)
        {
            decimal result = 0;
            if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                     months = Math.Max(0, months - 6);
                     return result = months * this.InterestRate;
                }
            }

            else
            {
                if (months <= 12)
                {
                    this.InterestRate /= 2;
                    return result = months * this.InterestRate;
                }
                else
                { 
                    months = Math.Max(0, months - 12);
                    return result = months * (this.InterestRate / 2) + months * this.InterestRate;
                }
            }
           
        }
    }
}
