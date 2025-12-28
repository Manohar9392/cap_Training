using System;
using College;
public class Program
{
    public static void Main(String[] args)
    {
        string Hod_name;
        int Hod_id;
        string Hod_dept;
        string Ex_name;
        int Ex_id;
        string Ex_dept;
        bool Ex_avail;
        string Exam_name;
        int Exam_id;
        int Sem_id;
        string Loc_name;
        int Loc_date;
        bool flag=true;
        do{
        Console.WriteLine("Please choose option from Given Below details: ");
        Console.WriteLine("Enter 1 for Update Hod details");
        Console.WriteLine("Enter 2 for Student details");
        Console.WriteLine("Enter 3 for update Exam details");
        Console.WriteLine("Enter 4 for update Semister details");
        Console.WriteLine("Enter 5 for update Exam Location Details");
        Console.WriteLine("Enter 0 to Exit !");
        Console.Write("Enter your choice: ");
        int choice=int.TryParse(Console.ReadLine(),out choice)?choice:0;

        switch(choice){
        case(1):
        #region Hod-details
        Console.WriteLine("Enter the Hod details name,id,Department: ");
        Console.Write("Enter hod name: ");
        Hod_name=Console.ReadLine();
        Console.Write("enter the Hod_id: ");
        Hod_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Console.Write("Enter the Hod Department: ");
         Hod_dept=Console.ReadLine();
        
        break;
        #endregion



        #region Examinor Details
        case(2):
        Console.WriteLine("Enter the Examinor details name,id,Department,Availability: ");
        Console.Write("Enter Examinor name: ");
        Ex_name=Console.ReadLine();
        Console.Write("enter the Examinor id: ");
        Ex_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        Console.Write("Enter the Examinor Department: ");
        Ex_dept=Console.ReadLine();
        Console.Write("Enter the Availability of Examinor true or false: ");
        Ex_avail=bool.TryParse(Console.ReadLine(),out Ex_avail)?Ex_avail:false;
        
        break;
        #endregion

        #region Exam details
        case(3):
        Console.WriteLine("Enter the Exam details name,id ");
        Console.Write("Enter Exam name: ");
         Exam_name=Console.ReadLine();
        Console.Write("enter the Exam id: ");
        Exam_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        
        break;
        #endregion

        #region Semister details
        case(4):
        Console.WriteLine("Enter the Semister details id ");
        Console.Write("enter the Semister id: ");
        Sem_id=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
        
        break;
        #endregion


        #region 
        case(5):
        Console.WriteLine("Enter the Exam Location details Date,Location ");
        Console.Write("Enter Exam Location name: ");
        Loc_name=Console.ReadLine();
        Console.Write("enter the Exam Location date: ");
        Loc_date=int.TryParse(Console.ReadLine(),out Hod_id)?Hod_id:0;
       
        break;
        #endregion

        default:
        flag=false;
        break;
        }

        }while(flag);
        Hod h1=new Hod (Hod_name,Hod_id,Hod_dept);
        Examinor E1=new Examinor(Ex_name,Ex_id,Ex_dept,Ex_avail);
        Exam e=new Exam(Exam_name,Exam_id);
        Semister s=new Semister(Sem_id);
         Assign_exam a=new Assign_exam(Loc_date,Loc_name);
        h1.Schedule(E1,a,e,s);

    }
}