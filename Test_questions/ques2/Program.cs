using System;

 public class Employee
{
    public string Name{get;set;}
    public int Id{get;set;}

    public decimal Salary{get;set;}

    public Employee()
    {
        
    }

    public Employee(string name,int id,decimal salary)
        {
            Name=name;
            Id=id;
            Salary=salary;
        }
    
    public void GetDetails()
        {
            Console.WriteLine($"Name is {Name}");
            Console.WriteLine($"Employee id is: {Id}");
            Console.WriteLine($"Employee salary is: {Salary}");
        }

}

public class Program
{
   
    public static void Main(string[] args)
    {
        // Employee emp=new Employee("manu",10,30000);
        // emp.GetDetails();
        List<Employee> emps=new List<Employee>();
        emps.Add(new Employee{Name="a",Id=1,Salary=1000});
        emps.Add(new Employee{Name="b",Id=2,Salary=2000});
        emps.Add(new Employee{Name="c",Id=3,Salary=3000});

        int first=emps[0].Id;
        int second=0;

        foreach(var v in emps)
        {
            if(v.Id>first)
            {
                second=first;
                first=v.Id;
                
            }
            else if(v.Id>second && v.Id!=first)
            {
                second=v.Id;
            }
        }
        Console.WriteLine(second);
        
    }
}