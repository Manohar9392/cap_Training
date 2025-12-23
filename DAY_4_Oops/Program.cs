
using System;
using Constructers;
using Oops_2;
using Chaining_Constructers;
using Fields_Oops;
using Problem;
using Accesability;
using System.Security.Principal;
using System.Linq.Expressions;
class Program
{
    public static void Main(string[] args)
    {
        // Visitor vis= new Visitor(1,"manu","Power bank");
        // Visitor vis1=new Visitor(2);
        // Visitor vis2=null;
        // try{
        //  vis2=new Visitor(2,"ram");
        // }
        // catch(ArgumentException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
       
        
        
        // vis.Display();
        // vis1.Display();
        // if(vis2!=null)
        //  {
        //     vis2.Display();
        //  }
       
        

        // Console.WriteLine("Enter first number:");
        // int n1=int.TryParse(Console.ReadLine(),out n1)?n1:0;
        // Console.WriteLine("Enter second number:");
        // int n2=int.TryParse(Console.ReadLine(),out n2)?n2:0;

        // Addition add=new Addition(n1,n2);
        // add.Display();


        Login_history log=new Login_history(1,"manu","charger");
        log.Display();  


        // Employee emp=new Employee();
        // emp.Id=5;
        // Console.WriteLine(emp.Employee_id());

        
        // Associate assoc=new Associate();
        // assoc.Id=10;
        // Console.WriteLine(assoc.Id);
        // assoc.Rank=-3;
        // Console.WriteLine(assoc.log);

        // Account acc= new Account();
        // acc.Id=101;
        // Console.WriteLine(acc.GetDetails());
        // SalesAccount sacc= new SalesAccount();
        // sacc.Id=201;
        // Console.WriteLine(sacc.GetSalesDetails());


        



        
    }
}