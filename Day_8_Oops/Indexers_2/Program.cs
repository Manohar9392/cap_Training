using System;
using model;
public class Program
{
    public static void Main(string[] args)
    {
        Mydata data=new Mydata();
        data.Name="manu";
        data.Id=34;
        data.Address="India";
        data[0]="Maths";
        data[1]="Science";
        

        Console.WriteLine(data.Name);
        Console.WriteLine(data.Id);
        Console.WriteLine(data.Address);
        Console.WriteLine(data[0]);
        Console.WriteLine(data[1]);
    }
}