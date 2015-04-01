using Bank_accounts.AcountTypes;
using Bank_accounts.CustomerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    class BankTEST
    {
        static void Main(string[] args)
        {
            // Deposit Account
            Console.WriteLine(new string('=', 40) + " Deposit Accounts " + new string('=', 40) + "\n");

            DepositAccount depositAccount = new DepositAccount(new Individual("Ivan Petkov"), 1000m, 0.5m);
            System.Console.WriteLine(depositAccount);

            var depositInterestRate = depositAccount.CalculateInterestRateForAGivenPeriod(3);
            Console.WriteLine("Interest rate for given period: " + depositInterestRate + "%");

            depositAccount.Deposit(500);
            Console.WriteLine(depositAccount);
            depositAccount.Withdraw(100);
            Console.WriteLine(depositAccount);
            Console.WriteLine("\n" + new string('=', 40) + " Loan Accounts " + new string('=', 40) + "\n");

            // Loan Accounts
            LoanAccount loanAccountC = new LoanAccount(new Company("PrismaTek"), 2000m, 1.5m);
            LoanAccount loanAccountI = new LoanAccount(new Individual("Yordan Genchev"), 300m, 0.5m);

            System.Console.WriteLine(loanAccountC);
            System.Console.WriteLine(loanAccountI);

            var loanInterestRateC = loanAccountC.CalculateInterestRateForAGivenPeriod(3);
            var loanInterestRateI = loanAccountI.CalculateInterestRateForAGivenPeriod(3);
            Console.WriteLine("Interest rate for given period: " + loanInterestRateC + "%");
            Console.WriteLine("Interest rate for given period: " + loanInterestRateI + "%");

            loanAccountC.Deposit(500);
            Console.WriteLine(loanAccountC);
            Console.WriteLine("\n" + new string('=', 40) + " Mortgage Accounts " + new string('=', 40) + "\n");

            // Mortgage Accounts
            MortgageAccount mortgageAccountC = new MortgageAccount(new Company("Peshkirov Inc."), 2000m, 1.5m);
            MortgageAccount mortgageAccountI = new MortgageAccount(new Individual("Petko Shterev"), 300m, 0.5m);

            System.Console.WriteLine(mortgageAccountC);
            System.Console.WriteLine(mortgageAccountI);

            var mortgageInterestRateC = mortgageAccountC.CalculateInterestRateForAGivenPeriod(12);
            var mortgageInterestRateI = mortgageAccountI.CalculateInterestRateForAGivenPeriod(7);
            Console.WriteLine("Interest rate for given period: " + mortgageInterestRateC + "%");
            Console.WriteLine("Interest rate for given period: " + mortgageInterestRateI + "%");

            mortgageAccountI.Deposit(500);
            Console.WriteLine(mortgageAccountI);
            Console.WriteLine("\n"+new string('=', 40) + " Bank " + new string('=', 40)+"\n");

            // Bank

            Bank bank = new Bank();
            bank.AddAccount(depositAccount);
            bank.AddAccount(loanAccountC);
            bank.AddAccount(loanAccountI);
            bank.AddAccount(mortgageAccountC);
            bank.AddAccount(mortgageAccountI);
            Console.WriteLine(bank);





        }
    }
}
