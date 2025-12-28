using System;
using Model;
using Data;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
       var res= DataBank.Getdetails_of_Students();
       foreach(var i in res)
        {
            Console.WriteLine($"{i.Name} {i.Id}");
        }
        Console.WriteLine("--------------------------------------------------------");

        Console.WriteLine("Sessions details are: ");
        var res1=DataBank.Getdetails_of_Sessions();
        foreach(var v in res1)
        {
            Console.WriteLine($"Session Name is: {v.Name} and id is: {v.Id}");
        }

        Console.WriteLine("--------------------------------------------------------");

        Console.WriteLine("Session details are: ");
        DataBank.MakeSessions();
        var res2=DataBank.Getdetails_of_onesession();
        foreach(var v in res2)
        {
            Console.WriteLine($"->Student present in {v.Session.Name} session are: ");
            foreach(var i in v.Student1)
            {
                Console.WriteLine($"student name: {i.Name} with id: {i.Id}");
            }
        }


       
    }
}