using System;
using model;
public class Program
{
    public static void Main(string[] args)
    {
        Upi u=new Upi();
        u.Make_Payment(200);
        Credit c=new Credit();
        c.Make_Payment(400);
        NetBanking n=new NetBanking();
        n.Make_Payment(600);
       
        Console.WriteLine(Payment.Balance);





    }
}