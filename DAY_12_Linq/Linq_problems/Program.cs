using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
    public string Department { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Sample student data
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Arjun", Marks = 85, Department = "CSE" },
            new Student { Id = 2, Name = "Meera", Marks = 72, Department = "ECE" },
            new Student { Id = 3, Name = "Rahul", Marks = 90, Department = "CSE" },
            new Student { Id = 4, Name = "Anita", Marks = 60, Department = "MECH" },
            new Student { Id = 5, Name = "Vikram", Marks = 40, Department = "ECE" }
        };

        // 1. WHERE - students with marks > 70
        var highScorers = students.Where(s => s.Marks > 70);
        Console.WriteLine("Students with marks > 70:");
        foreach (var s in highScorers)
            Console.WriteLine(s.Name);

        // 2. SELECT - student names only
        var names = students.Select(s => s.Name);
        Console.WriteLine("\nStudent Names:");
        foreach (var name in names)
            Console.WriteLine(name);

        // 3. ORDER BY DESCENDING - sort by marks
        var sortedByMarks = students.OrderByDescending(s => s.Marks);
        Console.WriteLine("\nStudents sorted by marks:");
        foreach (var s in sortedByMarks)
            Console.WriteLine($"{s.Name} - {s.Marks}");

        // 4. FIRST OR DEFAULT - first CSE student
        var firstCseStudent = students.FirstOrDefault(s => s.Department == "CSE");
        Console.WriteLine("\nFirst CSE Student:");
        Console.WriteLine(firstCseStudent != null ? firstCseStudent.Name : "No student found");

        // 5. GROUP BY - group students by department
        var groupedByDept = students.GroupBy(s => s.Department);
        Console.WriteLine("\nStudents grouped by department:");
        foreach (var group in groupedByDept)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var s in group)
                Console.WriteLine($"  {s.Name}");
        }

        // 6. ANY - check if any student failed
        bool hasFailed = students.Any(s => s.Marks < 50);
        Console.WriteLine("\nAny student failed (<50 marks): " + hasFailed);

        // 7. AVERAGE - average marks
        double averageMarks = students.Average(s => s.Marks);
        Console.WriteLine("\nAverage Marks: " + averageMarks);

        // 8. COUNT - number of ECE students
        int eceCount = students.Count(s => s.Department == "ECE");
        Console.WriteLine("\nNumber of ECE students: " + eceCount);
    }
}
