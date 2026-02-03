using SchoolApp;
using SchoolApp;
using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n=== STUDENT GRADE SYSTEM ===");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Grade");
            Console.WriteLine("3. Group By Grade Level");
            Console.WriteLine("4. Student Average");
            Console.WriteLine("5. Top Performers");
            Console.WriteLine("0. Exit");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1: AddStudentMenu(); break;
                case 2: AddGradeMenu(); break;
                case 3: DisplayGrouped(); break;
                case 4: AverageMenu(); break;
                case 5: TopMenu(); break;
            }
        } while (choice != 0);
    }

    static void AddStudentMenu()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Grade Level: ");
        string grade = Console.ReadLine();

        SchoolManager.AddStudent(name, grade);
    }

    static void AddGradeMenu()
    {
        Console.Write("Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Subject: ");
        string subject = Console.ReadLine();

        Console.Write("Grade: ");
        double grade = double.Parse(Console.ReadLine());

        SchoolManager.AddGrade(id, subject, grade);
    }

    static void DisplayGrouped()
    {
        foreach (var g in SchoolManager.GroupStudentsByGradeLevel())
        {
            Console.WriteLine($"\n{g.Key}");
            foreach (var s in g.Value)
                Console.WriteLine($"{s.StudentId} - {s.Name}");
        }
    }

    static void AverageMenu()
    {
        Console.Write("Student ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine(SchoolManager.CalculateStudentAverage(id));
    }

    static void TopMenu()
    {
        Console.Write("Count: ");
        int count = int.Parse(Console.ReadLine());

        foreach (var s in SchoolManager.GetTopPerformers(count))
            Console.WriteLine(s.Name);
    }
}
