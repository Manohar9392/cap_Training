using Employee_onboarding;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee("manu", "1", 10000, "vmanu@gmail.com");
        Employee emp2 = new Employee("manu", "2", -10000, "dotgmail");
        Employee emp3 = new Employee("manu", "3", 40000, "mdnuf");


        EmployeeUtility.GetEmployeeDetails();


    }
}