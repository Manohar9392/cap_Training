
using System;
using Constructers;
using Oops_2;
using Chaining_Constructers;
using Fields_Oops;
class Program
{
    public static void Main(string[] args)
    {
        // Visitor vis= new Visitor(1,"manu","Power bank");
        // Visitor vis1=new Visitor(2);
        // try{
        // Visitor vis2=new Visitor(2,"ram");
        // }
        // catch(ArgumentException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
       
        
        
        // vis.Display();
        // vis1.Display();
        //vis2.Display();
        

        // Console.WriteLine("Enter first number:");
        // int n1=int.TryParse(Console.ReadLine(),out n1)?n1:0;
        // Console.WriteLine("Enter second number:");
        // int n2=int.TryParse(Console.ReadLine(),out n2)?n2:0;

        // Addition add=new Addition(n1,n2);
        // add.Display();


        // Login_history log=new Login_history(1,"manu","charger");
        // log.Display();  


        Employee emp=new Employee();
        emp.Id=5;
        Console.WriteLine(emp.Employee_id());


        
    }
}