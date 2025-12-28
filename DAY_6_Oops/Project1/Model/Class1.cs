namespace Model{

    public class Student
    {
        public int Id{get;set;}
        public string? Name{get;set;}

        public Student()
        {
            
        }

    }

    public class StudentSession
    {
        public int Id{get;set;}
        public string? Name{get;set;}

        

        public StudentSession()
        {
            
        }


    }

    public class StudentAndSession
    {
        public List<Student> Student1=new List<Student>();
        public StudentSession Session{get;set;}
    }



}
