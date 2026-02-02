using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_on_bank_account_testcase
{
    public class BankAccount
    {
        // Property to store current balance
        public decimal Balance { get; private set; }

        // Constructor to initialize balance
        public BankAccount(decimal initialBalance)
        {
            // Initial balance should not be negative
            if (initialBalance < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(initialBalance),
                    "Initial balance cannot be negative"
                );
            }

            Balance = initialBalance;
        }

        // Method to deposit amount into account
        public void Deposit(decimal amount)
        {
            // Deposit amount should be greater than zero
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "Deposit amount cannot be negative"
                );
            }

            // Increase balance
            Balance += amount;
        }

        // Method to withdraw amount from account
        public void Withdraw(decimal amount)
        {
            // Withdrawal amount should be greater than zero
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "Withdraw amount must be greater than zero"
                );
            }

            // Check for sufficient balance
            if (amount > Balance)
            {
                throw new InvalidOperationException(
                    "Insufficient funds."
                );
            }

            // Decrease balance
            Balance -= amount;
        }
    }
}
