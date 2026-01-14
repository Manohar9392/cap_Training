namespace model{

public class Employee
{
    public string Name{get;set;}
    public int Id{get;set;}

    public decimal Salary{get;set;}

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
}
