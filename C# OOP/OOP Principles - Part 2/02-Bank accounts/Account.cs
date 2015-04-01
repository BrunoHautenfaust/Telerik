
namespace Bank_accounts
{
    public abstract class Account : Bank, IDepositable
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal interestRate;

        public Customer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
      
        public virtual decimal CalculateInterestRateForAGivenPeriod(int months)
        {
           decimal result = 0m;
           return result = months * this.InterestRate;
        }
        public void Deposit(decimal sum)
        {
            this.Balance += sum;
            System.Console.WriteLine("---> A deposit of {0} lv. was made.", sum);
        }

        public override string ToString()
        {
            return string.Format("Customer: {0}     \tBalance: {1} lv.\tInterest Rate(monthly): {2}%", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
