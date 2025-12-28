using System;
using College;
public class Program
{
    public static void Main(String[] args)
    {
        #region Hod-details
        Console.WriteLine("Enter the Hod details name,id,Department: ");
        Console.Write("Enter hod name: ");
        string Hod_name=Console.ReadLine();
        Console.Write("enter the Hod_id: ");
        int Hod_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Console.Write("Enter the Hod Department");
        string Hod_dept=Console.ReadLine();
        Hod h1=new Hod (Hod_name,Hod_id,Hod_dept);
        #endregion

        #region Examinor Details
        Console.WriteLine("Enter the Examinor details name,id,Department,Availability: ");
        Console.Write("Enter Examinor name: ");
        string Ex_name=Console.ReadLine();
        Console.Write("enter the Examinor id: ");
        int Ex_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Console.Write("Enter the Examinor Department");
        string Ex_dept=Console.ReadLine();
        Console.Write("Enter the Availability of Examinor true or false: ");
        bool Ex_avail=bool.TryParse(Console.ReadLine(),out Ex_avail)?Ex_avail:false;
        Examinor E1=new Examinor(Ex_name,Ex_id.Ex_dept,Ex_avail);
        #endregion

        #region Exam details
        Console.WriteLine("Enter the Exam details name,id ");
        Console.Write("Enter Exam name: ");
        string Exam_name=Console.ReadLine();
        Console.Write("enter the Exam id: ");
        int Exam_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Exam e=new Exam(Exam_name,Exam_id);
        #endregion

        #region Semister details
        Console.WriteLine("Enter the Semister details id ");
        Console.Write("enter the Semister id: ");
        int Sem__id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Semister s=new Semister(Sem__id);
        #endregion


        #region 
        Console.WriteLine("Enter the Exam Location details Date,Location ");
        Console.Write("Enter Exam Location name: ");
        string Loc_name=Console.ReadLine();
        Console.Write("enter the Exam Location date: ");
        int Loc_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Assign_exam a=new Assign_exam(Loc_id,Loc_name);
        h1.Schedule(E1,a,e,s);
        #endregion
    }
}