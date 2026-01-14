using System;
public class program
{
    public static void Main()
    {
        /*
        Predicate<int> Even= num=>num%2==0;
        Console.WriteLine(Even(5));
        */

        Action<string> logger=message=>
        {
            Console.WriteLine($"[LoG]: {message} at {DateTime.Now}");
        };
        logger += message =>
        {
            Console.WriteLine($"{message} forwarded");
        };
        logger("Application Started");
    }
}