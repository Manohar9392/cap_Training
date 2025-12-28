


using System.Collections;
using System.Data.Common;
using Model;
namespace Data{

public static class DataBank
{
    public static List<Student> Students=new List<Student>();
    public static List<StudentSession> Sessions=new List<StudentSession>();
    public static List<StudentAndSession> S=new List<StudentAndSession> ();

    static DataBank()
        {
            Students.Add(new Student(){Name="manu",Id=1});
            Students.Add(new Student(){Name="ram",Id=2});
            Students.Add(new Student(){Name="nani",Id=3});
            Students.Add(new Student(){Name="prem",Id=4});
            Sessions.Add(new StudentSession(){Name="Python",Id=101});
            Sessions.Add(new StudentSession(){Name="Science",Id=102});



             

        }
    public static void MakeSessions()
        {
            S.Add(new StudentAndSession(){Student1=Students,Session=Sessions[0]});
            
            
        }
    public static List<Student> Getdetails_of_Students()
        {
            return Students;
        }
    
    public static List<StudentSession> Getdetails_of_Sessions()
        {
            return Sessions;
        }
    public static List<StudentAndSession> Getdetails_of_onesession()
        {
            return S;
        }

}
}
