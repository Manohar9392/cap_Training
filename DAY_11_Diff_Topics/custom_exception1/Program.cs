using System;
using System.Reflection.Metadata;

public class program
{
    public class AppCustomException : Exception
    {
        public override string Message => Handle(base.Message);

        /// <summary>
        /// returns our own message and stores system exception
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>

        private string Handle(string message)
        {
            Console.WriteLine(message);//instead of printing we can store log file for future refrence
            return "Error! Internal exception occured";
        }
    }
    public static void Divide(int a,int b)
    {
        try
        {
            Console.WriteLine(a/b);
        }
        catch
        {
            throw new AppCustomException();
        }
    }
    public static void Main(string[] args)
    {
        int a=10;
        int b=0;
        try{
        Divide(a,b);
        }
        catch(AppCustomException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}