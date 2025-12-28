namespace College{

    public class Employee
    {
        public string Emp_name{get;set;}
        public int Emp_id{get;set;}

        public string Emp_dept{get;set;}


/// <summary>
/// Constructer to assign vals when obj created
/// </summary>
/// <param name="name"></param>
/// <param name="id"></param>
/// <param name="dept"></param>
        public Employee(string name,int id,string dept)
        {
            this.Emp_name=name;
            this.Emp_id=id;
            this.Emp_dept=dept;

        }
    }

    

    public class Hod : Employee
    {
        /// <summary>
        /// Construcer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="dept"></param>


        public Hod(String name,int id,string dept):base(name,id,dept)
        {
            Console.WriteLine("Hod details Updated");
            
        }
        /// <summary>
        /// Passing objs to Schdule the Exam
        /// </summary>
        /// <param name="E"></param>
        /// <param name="a"></param>
        /// <param name="e"></param>
        /// <param name="s"></param>


        public void Schedule(Examinor E,Assign_exam a,Exam e,Semister s)
        {
            if(E.Isavailable)
            {
            a.Assignment(E,e,s);
            }
            else
            {
                Console.WriteLine("Scheduled is cancelled due to non availability");
            }
        }




        
    }

    public class Examinor : Employee
    {
         public bool Isavailable{get;set;}

         /// <summary>
         /// Constructer to take Examinor details
         /// </summary>
         /// <param name="name"></param>
         /// <param name="id"></param>
         /// <param name="dept"></param>
         /// <param name="val"></param>

        public Examinor(String name,int id,string dept,bool val):base(name,id,dept)
        {
            Isavailable=val;
        }
    }


    public class Exam
    {
        public string Exam_name{get;set;}

        public int Code{get;set;}


        public Exam(string name,int code)
        {
            Exam_name=name;
            Code=code;

        }
    }


    public class Assign_exam
    {
        public int Exam_date{get;set;}
        public string Exam_Location{get;set;}

        /// <summary>
        /// Constructer to take the exam date and Location.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="location"></param>


        public Assign_exam(int date,string location)
        {
            Exam_date=date;
            Exam_Location=location;
        }

        /// <summary>
        /// Schedule the exam based on given details.
        /// </summary>
        /// <param name="E"></param>
        /// <param name="e"></param>
        /// <param name="s"></param>

        public void Assignment(Examinor E,Exam e,Semister s)
        {
            Console.WriteLine($" for the Examinor {E.Emp_name} with id {E.Emp_id} is to do Invigilation In Semister {s.Sem_id} the {e.Exam_name} is scheduled on {Exam_date} at {Exam_Location} ");
        }



    }

    public class Semister
    {
        public int Sem_id{get;set;}

        public Semister(int id)
        {
            Sem_id=id;
        }
    }


}
