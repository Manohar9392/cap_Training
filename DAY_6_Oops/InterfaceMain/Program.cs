using System;
using Iprintable;


public class Program 
{
    public static void Main(String[] args)
    {
        Scanable p= new Printer();
        Isprintable p1=new Printer();
        
        p.GetPrint();
        p1.GetPrint();
        
        
    }
}