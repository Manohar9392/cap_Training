
namespace partial_class{


public static class General
    {
        public static int roll;
        static General()
        {
            roll=10;
        }
        public static int  Get_details()
        {
            return roll;
        }
    }
public partial class Student{
    
    public string Name{get;set;}
    public int Id{get;set;}

    public void Main_student()
        {
            Console.WriteLine("i am from main class");
        }



}

  public partial class Student 
{
    public decimal Marks{get;set;}

    public void Partial_student()
        {
            Console.WriteLine("i am from partial class");
            Id=General.roll;
            Console.WriteLine(Id);
        }

}

public static class StringExtensions
    {
        public static int Wordcount(this string str)
        {
            return str.Count(c=>c.Equals(' '))+1;
        }
    }





}
