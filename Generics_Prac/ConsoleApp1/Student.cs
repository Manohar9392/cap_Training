using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public List<decimal> Marks = new List<decimal>();
        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Total { get; protected set; }

        public Student(int Id,string name,List<decimal> marks)
        {
            this.ID = Id;
            this.Name = name;
            this.Marks = marks;
            this.Total = this.GetTotal();
            StudentRegistory.students.Add(this);
            
        }
        


        public decimal GetTotal()
        {
            foreach(var item in Marks)
            {
                Total += item;
                
            }
            return Total;
        }

        public decimal GetAverage()
        {
            decimal avg = 0;
            avg = Total / Marks.Count;

            return avg;
        }




    }

    public static class StudentRegistory
    {
        public static List<Student> students= new List<Student>();



        public static void TopPerformer()
        {
            decimal val = 0;
            int Id = 0;
            foreach (var item in students)
            {
                if (item.Total > val)
                {
                    val = item.Total;
                    Id = item.ID;

                }
            }
            Console.WriteLine($"TopPerformer is with id: {Id} scored: {val}");
        }



    }
}
