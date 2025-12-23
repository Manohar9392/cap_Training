using System;
/// <summary>
/// Namespace for Tax Calculation program.
/// </summary>

namespace Tax_calculation
{
    /// <summary>
    /// Abstract Employee class defining the CalTax method.
    /// </summary>b
    public abstract class Employee
    {
        /// <summary>
        /// Calculates tax based on income.
        /// </summary>
        /// <param name="income"></param>
        /// <returns></returns>
        public abstract double CalTax(double income);
    }

    public class IndianEmployee : Employee
    {
        public int Salary{get; set;} // Annual Salary
        public double Tax{get; set;} // Taxable Income

/// <summary>
/// Constructor for IndianEmployee class.
/// </summary>
        public IndianEmployee()
        {
            Tax = 0;
            
        }

/// <summary>
/// Constructor with salary parameter.
/// </summary>
/// <param name="salary"></param>
        public IndianEmployee(int salary)
        {
            Salary = salary;
            Tax = CalTax(Salary);
        }
        /// <summary>
        /// Calculates tax for Indian employees based on income slabs.
        /// </summary>
        /// <param name="income"></param>
        /// <returns>Tax amount for Indian Employee</returns>
        public override double CalTax(double income)
        {
            if (income <= 250000)  // No tax for income up to 2.5 lakhs
                return 0;
            else if (income <= 500000) // 5% tax for income between 2.5 lakhs and 5 lakhs
                return (income - 250000) * 0.05;
            else if (income <= 1000000)   // 20% tax for income between 5 lakhs and 10 lakhs
                return (250000 * 0.05) + (income - 500000) * 0.2;
            else      // 30% tax for income above 10 lakhs
                return (250000 * 0.05) + (500000 * 0.2) + (income - 1000000) * 0.3;
        }
    }
     public class USEmployee : Employee
    {
        /// <summary>
        /// Calculates tax for US employees based on income slabs.
        /// </summary>
        /// <param name="income"></param>
        /// <returns>Tax amount for us Employee</returns>
        public override double CalTax(double income)
        {
            if (income <= 9875) // 10% tax for income up to 9875
                return income * 0.1;
            else if (income <= 40125) // 12% tax for income between 9875 and 40125
                return (9875 * 0.1) + (income - 9875) * 0.12;
            else if (income <= 85525) // 22% tax for income between 40125 and 85525
                return (9875 * 0.1) + (40125 - 9875) * 0.12 + (income - 40125) * 0.22;
            else            // 24% tax for income above 85525
                return (9875 * 0.1) + (40125 - 9875) * 0.12 + (85525 - 40125) * 0.22 + (income - 85525) * 0.24;
        }
    }

    public class Program
    {
        /// <summary>
        /// Main method - Entry point of the program.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            IndianEmployee indianEmp = new IndianEmployee(1200000);
            double indianTax = indianEmp.Tax;
            Console.WriteLine("Indian Employee Tax: " + indianTax+" for Salary: "+indianEmp.Salary);

            USEmployee usEmp = new USEmployee();
            double usTax = usEmp.CalTax(60000);
            Console.WriteLine("US Employee Tax: " + usTax);
        }
    }
}