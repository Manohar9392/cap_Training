using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_onboarding
{
    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; } = "Id";
            
        public double Salary { get; protected set; }

        public string Email { get; set; }

        public Employee(string name,string Id,double salary,string email)
        {
            this.Name = name;
           
            this.Id+= Id;
            if(salary < 0)
            {
                salary = 30000;
            }
            this.Salary = salary;
            if(!email.Contains("@"))
            {
                email = "unknownemail@gmail.com";
            }
            this.Email = email;

           EmployeeUtility.
                Employess.Add(this);

        }
    }


    public class EmployeeUtility
    {
        public static List<Employee> Employess= new List<Employee>();

        public static void GetEmployeeDetails()
        {
            foreach(Employee emp in Employess)
            {
                Console.WriteLine($"Name: {emp.Name}, Id: {emp.Id}, Salary: {emp.Salary}, Email: {emp.Email}");
            }
        }



    }
}
