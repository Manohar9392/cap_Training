using System;
public class TooManyLoginAttemptsException : Exception
{
    public TooManyLoginAttemptsException(string message) : base(message)
    {
    }
}

class LoginSystem
{
    static int attempts = 0;
    public static void Login()
    {
        if(attempts>=3)
        {
            throw new TooManyLoginAttemptsException("Too many login attempts. Access denied.");
        }
        attempts++;

    }
    static void Main()
    {
        for(int i=0;i<100;i++)
        {
            try
            {
                Login();
            }
            catch(TooManyLoginAttemptsException ex)
            {
                Console.WriteLine(ex.Message);
                break;
            }
            Console.WriteLine("Login attempt " + i + " successful.");
        }
        Console.ReadLine();

        // TODO:
        // 1. Allow only 3 login attempts
        // 2. Create and throw custom exception after limit
        // 3. Handle exception and terminate application
    }
}