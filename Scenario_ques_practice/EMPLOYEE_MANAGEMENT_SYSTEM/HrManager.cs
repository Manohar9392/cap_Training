using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApp
{
    public static class HRManager
    {
        static int id = 1;
        public static List<Employee> employees = new List<Employee>();

        /// <summary>
        /// Adds a new employee record with the specified name, department, and salary.
        /// </summary>
        /// <param name="name">The full name of the employee to add. Cannot be null or empty.</param>
        /// <param name="dept">The department to which the employee belongs. Cannot be null or empty.</param>
        /// <param name="salary">The salary assigned to the employee. Must be a non-negative value.</param>

        public static void AddEmployee(string name, string dept, double salary)
        {
            string empId = "E" + id++.ToString("D3");
            employees.Add(new Employee(empId, name, dept, salary));
        }

        /// <summary>
        /// Groups all employees by their department and returns the results as a sorted dictionary.
        /// </summary>
        /// <returns>A sorted dictionary where each key is a department name and the corresponding value is a list of employees
        /// in that department. If there are no employees, the dictionary will be empty.</returns>

        public static SortedDictionary<string, List<Employee>> GroupEmployeesByDepartment()
        {
            return new SortedDictionary<string, List<Employee>>(
                employees.GroupBy(e => e.Department)
                .ToDictionary(g => g.Key, g => g.ToList()));
        }

        /// <summary>
        /// Calculates the total salary for all employees in the specified department.
        /// </summary>
        /// <param name="dept">The name of the department for which to calculate the total salary. Cannot be null.</param>
        /// <returns>The sum of the salaries of all employees in the specified department. Returns 0 if no employees are found in
        /// the department.</returns>

        public static double CalculateDepartmentSalary(string dept)
        {
            return employees.Where(e => e.Department == dept).Sum(e => e.Salary);
        }

        public static List<Employee> GetEmployeesJoinedAfter(DateTime date)
        {
            return employees.Where(e => e.JoiningDate > date).ToList();
        }
    }
}
