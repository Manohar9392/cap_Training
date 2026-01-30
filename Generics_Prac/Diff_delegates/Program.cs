using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}


/// <summary>
/// here we are performing diff delegates like action,func,predicate   diff is predicate will return bool and 
/// action is void return type and 
/// by using func we can mention whichever return type we want..! 
/// </summary>

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Manu", Marks = 85 },
            new Student { Name = "Ravi", Marks = 45 },
            new Student { Name = "Anita", Marks = 72 }
        };
        

        // Predicate<T> → returns bool
        Predicate<Student> isPassed = s => s.Marks >= 50;
        //public delegate bool isPasses(Student s) return s.Marks>=50

        // Func<T, TResult> → returns a value
        Func<Student, string> calculateGrade = s =>
        //public delegate string CalculateGrade(Student s);



        {
            if (s.Marks >= 80) return "A";
            if (s.Marks >= 60) return "B";
            return "C";
        }
        ;

        // Action<T> → returns void
        Action<Student> printStudent = s =>
        //public delegate void printStudent(Student s){Console.WriteLine(
            //    $"Name: {s.Name}, Marks: {s.Marks}, Grade: {calculateGrade(s)}"
            //);}
        {
            Console.WriteLine(
                $"Name: {s.Name}, Marks: {s.Marks}, Grade: {calculateGrade(s)}"
            );
        };

        Console.WriteLine("Passed Students:\n");

        foreach (var student in students)
        {
            if (isPassed(student))
            {
                printStudent(student);
            }
        }
    }
}
