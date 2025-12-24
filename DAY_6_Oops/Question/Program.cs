using System;
using College;
public class Program
{
    public static void Main(String[] args)
    {
        Hod h1=new Hod ("manu",4,"Science");
        Examinor E1=new Examinor("ram",5,"maths",false);
        Exam e=new Exam("maths",202);
        Semister s=new Semister(8);
        Assign_exam a=new Assign_exam(25,"law block");
        h1.Schedule(E1,a,e,s);
    }
}