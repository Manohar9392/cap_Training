using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Encapsulation_Deposit
{
    public class BankAccount
    {
        public string AccountHolder { get; private set; }
        private decimal Balance { get;  set; }

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Current balance for {AccountHolder}: {Balance:C}");
        }

        public void Deposit(decimal amount)
        {
            if(amount<0)
            {
                throw new ArgumentException("Deposit amount cannot be negative.");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to {AccountHolder}'s account.");

            }
        }

        public void Withdraw(decimal amount)
        {
            if(amount<0)
            {
                throw new ArgumentException("Withdrawal amount cannot be negative.");
            }
            else if(amount>Balance)
            {
                throw new ArgumentException("Insufficient funds for withdrawal.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from {AccountHolder}'s account.");
            }
        }
    }
}
