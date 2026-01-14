using System;
public class Program
{
    public static void task1()
    {
        Console.WriteLine("printing odd nums: ");
        for (int i=1;i<100;i+=2)
        {
            Console.Write(i+" ");
        }

    }

    public static void task2()
    {
        Console.WriteLine("printing even nums: ");
        for (int i=0;i<100;i+=2)
        {
            Console.Write(i+" ");
        }
        
    }
    public static void Main()
    {
        Thread t1=new Thread(task1);
        Thread t2 =new Thread(task2);
        t1.Start();
        t2.Start();
    }
}