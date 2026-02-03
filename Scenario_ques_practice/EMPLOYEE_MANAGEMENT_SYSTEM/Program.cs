using System;
using EmployeeApp;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n=== EMPLOYEE MANAGEMENT ===");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Group By Department");
            Console.WriteLine("3. Department Salary");
            Console.WriteLine("4. Joined After Date");
            Console.WriteLine("0. Exit");
            Console.Write("Choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1: AddEmployeeMenu(); break;
                case 2: DisplayGroupedEmployees(); break;
                case 3: SalaryMenu(); break;
                case 4: JoinedAfterMenu(); break;
            }
        } while (choice != 0);
    }

    static void AddEmployeeMenu()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Department: ");
        string dept = Console.ReadLine();

        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine());

        HRManager.AddEmployee(name, dept, salary);
        Console.WriteLine("Employee added.");
    }

    /// <summary>
    /// Displays a list of employees grouped by their department in the console output.
    /// </summary>
    /// <remarks>Each department is printed with its name, followed by the employee ID, name, and salary for
    /// each employee in that department. This method is intended for console-based inspection and does not return any
    /// data.</remarks>
    static void DisplayGroupedEmployees()
    {
        var data = HRManager.GroupEmployeesByDepartment();
        foreach (var g in data)
        {
            Console.WriteLine($"\nDepartment: {g.Key}");
            foreach (var e in g.Value)
                Console.WriteLine($"{e.EmployeeId} - {e.Name} - {e.Salary}");
        }
    }

    /// <summary>
    /// Prompts the user to enter a department name and displays the total salary for that department.
    /// </summary>
    /// <remarks>This method reads input from the console and writes the calculated total salary to the
    /// console output. The calculation is performed by calling HRManager.CalculateDepartmentSalary with the specified
    /// department name.</remarks>

    static void SalaryMenu()
    {
        Console.Write("Department: ");
        string dept = Console.ReadLine();

        Console.WriteLine("Total Salary: " +
            HRManager.CalculateDepartmentSalary(dept));
    }
    /// <summary>
    /// Prompts the user to enter a date and displays a list of employees who joined after the specified date.
    /// </summary>
    /// <remarks>This method reads user input from the console and expects the date to be entered in the
    /// format yyyy-mm-dd. The list of employees is retrieved using HRManager.GetEmployeesJoinedAfter, and each
    /// employee's name and joining date are displayed. If the input is not a valid date, an exception may be
    /// thrown.</remarks>

    static void JoinedAfterMenu()
    {
        Console.Write("Enter Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        foreach (var e in HRManager.GetEmployeesJoinedAfter(date))
            Console.WriteLine($"{e.Name} - {e.JoiningDate}");
    }
}
