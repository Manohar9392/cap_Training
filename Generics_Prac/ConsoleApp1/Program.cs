using System;
using System.ComponentModel;
using ConsoleApp1;
public class Program
{
    public delegate string Notify();
    
    public static string IsLessThan40()
    {
        return $" your Average is less than 40 ";
    }

    public static string IsMoreThan90()
    {
        return $" you are perfoming well ";
    }

    public static void Main(string[] args)
    {
        string name;
        int id;
        int choice;
        
        bool loop = true;
        while (loop)
        {
            Console.Write("Enter 1 for enter details 0 to exit");
            choice=int.TryParse(Console.ReadLine(), out choice)?choice:0;
            if(choice==1)
            {
                Console.Write("Enter the name: ");
                name=Console.ReadLine();
                Console.Write("Enter the id: ");
                id= int.TryParse(Console.ReadLine(), out id) ? id : 0;
                decimal mark;
                List<decimal> marks=new List<decimal>();
                for(int i=0;i<3;i++)
                {
                    Console.Write($"enter marks for Subject {i + 1}: ");
                    mark= decimal.TryParse(Console.ReadLine(), out mark) ? mark : 0;
                    marks.Add( mark );

                }
                new Student(id, name, marks);

            }
            else
            {
                break;
            }
            
        }
        
        

        StudentRegistory.TopPerformer();
        Notify note;

        foreach (var s in StudentRegistory.students)
        {
            note = null;
            if (s.GetAverage() <= 40)
            {
                note = IsLessThan40;
                
            }
            else if (s.GetAverage() >= 90)
            {
                note = IsMoreThan90;
                

            }
            if (note != null)
            {
                Console.WriteLine($"The student with id:{s.ID} {note()}");
            }

        }

        Console.WriteLine();
        Console.ReadLine();

    }
}