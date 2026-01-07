using System;
using System.Net;
using part1;


public class Program
{
    public static void Main(string [] args)
    {
        Class1 c=new Class1();
        c.a=7;
        c.b=9;
        // c.delegateEx1();
        // // Console.WriteLine(c.result);
        Calling_delegate c1=new Calling_delegate();
        c1.v1=c;

        c1.Call();

        
    }
}