using System;
using System.ComponentModel.Design;

public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
        
    }
}

class BankAccount
{
    public int balance { get; private set; } = 10000;

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            throw new CustomException("Withdrawal amount must be greater than zero.");
        }
        if (amount > balance)
        {
            throw new CustomException("Insufficient funds for this withdrawal.");
        }
        balance -= amount;
    }

}
public class Program
{
    public static void Main(string[] args)
    {
       
            BankAccount bankAccount = new BankAccount();
            

            Console.WriteLine("Enter withdrawal amount:");
            int amount = int.Parse(Console.ReadLine());

            try
            {
                bankAccount.Withdraw(amount);
                Console.WriteLine($"Withdrawal of {amount} successful. New balance: {bankAccount.balance}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

       
            finally
            {
                Console.WriteLine("Transaction logged.");

            }
            Console.ReadLine();
       
                // TODO:
                // 1. Throw exception if amount <= 0
                // 2. Throw exception if amount > balance
                // 3. Deduct amount if valid
                // 4. Use finally block to log transaction
            
    }
}