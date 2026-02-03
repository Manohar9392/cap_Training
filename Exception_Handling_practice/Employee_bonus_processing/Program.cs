using System;

class BonusCalculator
{
    public static void Bonus(int[] salaries)
    {
        int bonus = 1000;
        foreach (var salary in salaries)
        {
            try
            {
                int bonusPerEmployee = bonus / salary;
                Console.WriteLine($"Bonus for employee with salary {salary}: {bonusPerEmployee}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Cannot calculate bonus for employee with salary {salary}: Division by zero is not possible.");
            }

            catch (ArithmeticException)
            {
                Console.WriteLine($"Cannot calculate bonus for employee with salary {salary}: Division by zero.");
            }
        }

    }
    static void Main()
    {
        int[] salaries = { 500, 0, 700 };
        
        
            Bonus(salaries);
        
        Console.ReadLine();

        // TODO:
        // 1. Loop through salaries
        // 2. Divide bonus by salary
        // 3. Handle DivideByZeroException
        // 4. Continue processing remaining employees
    }
}