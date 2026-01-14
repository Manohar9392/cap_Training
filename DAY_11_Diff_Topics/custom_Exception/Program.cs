using System;
public class Program
{
    public class AppCustomException:Exception{
        public override string Message => "Internal Exception";
        
    }

    public static int divide(int a,int b)
    {
        try
        {
            return a/b;
        }
        catch(DivideByZeroException)
        {
            throw new AppCustomException();
        }
       
        
    }
    public static void Main(string[] args)
    {
        int a=10;
        int b=0;
        int result ;
        try{
        divide(a,b);
        }
        catch(AppCustomException ex)
        {
            Console.WriteLine("error! "+ex.Message);
        }
        
        
    }
}