using System;

namespace EmployeeApp
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        /// <summary>
        /// Initializes a new instance of the Employee class with the specified identifier, name, department, and
        /// salary.
        /// </summary>
        /// <remarks>The employee's joining date is set to the current date and time when the instance is
        /// created.</remarks>
        /// <param name="id">The unique identifier for the employee. Cannot be null or empty.</param>
        /// <param name="name">The full name of the employee. Cannot be null or empty.</param>
        /// <param name="dept">The department to which the employee belongs. Cannot be null or empty.</param>
        /// <param name="salary">The initial salary assigned to the employee, in the local currency. Must be a non-negative value.</param>

        public Employee(string id, string name, string dept, double salary)
        {
            EmployeeId = id;
            Name = name;
            Department = dept;
            Salary = salary;
            JoiningDate = DateTime.Now;
        }
    }
}
