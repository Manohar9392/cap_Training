using System;
public class Program
{
    public static bool IsvalidEmail(string val)
    {
        if (string.IsNullOrEmpty(val) || val.Length < 10)
        {
            return false;
        }
        else if (val.Contains("@"))
        {
           
            string[] store = val.Split("@");
            if (store[store.Length - 1] != "gmail.com" || store.Length!=2)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        return false;


            
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the email: ");
        string val=Console.ReadLine();
        Console.WriteLine(IsvalidEmail(val));
    }
}