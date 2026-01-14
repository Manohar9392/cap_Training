using System;
using model;

public class Program
{
    public static void SendMail(string message)
    {
        Console.WriteLine($"msg : {message}");
    }
    public static void Main(string[] args)
    {
        OrderService service=new OrderService();
        service.IsPlaced("Id-01",SendMail);
    }
}