using System;

class Program
{
    static void Main()
    {
        Console.Write("Is card inserted? (yes/no): ");
        string card = Console.ReadLine().ToLower();

        if (card == "yes")
        {
            Console.Write("Enter PIN: ");
            int pin = int.Parse(Console.ReadLine());

            if (pin == 1234)   // assume valid PIN
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());

                double balance = 5000; // assume account balance

                if (amount <= balance)
                {
                    Console.WriteLine("Transaction successful. Please collect cash.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN.");
            }
        }
        else
        {
            Console.WriteLine("Please insert your card.");
        }
    }
}
