using Banking_Encapsulation_Deposit;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            BankAccount account = new BankAccount("John Doe", 1000);
            BankAccount account2 = new BankAccount("Jane Doe", 500);

            account.GetBalance();

            account.Deposit(200);

            account.Deposit(1000);
            account.GetBalance();
            account.Withdraw(15000);

            account.GetBalance();
             //account.Withdraw(2000);
             //account.GetBalance();


        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error creating account: {ex.Message}");

        }
        
        
        finally{
            Console.WriteLine("Program execution completed.");

        }
    }
}