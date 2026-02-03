using System;

class InputHandler
{
    static void Main()
    {
        int n;
        
        while(true)
        {
            
            try
            {
                Console.Write("Enter the valid number: ");
                n=int.Parse(Console.ReadLine());                     // Read input from user 
                Console.WriteLine(n);
                Console.WriteLine( (double)n / 100);
                break;                                               // Exit loop if input is valid
            }
            catch(FormatException) 
            {
                Console.WriteLine("Invalid input. Please enter a valid number in integer form.");// Handle invalid numeric input
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

        }
        // TODO:
        // 1. Read input from user
        // 2. Handle invalid numeric input
        // 3. Keep asking until valid number is entered

    }
}