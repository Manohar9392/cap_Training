using System;
namespace Fields_Oops
{
    public class Employee
    {
        private int id;
        public int Id
        {
            set
            {
                if(Id>0)
                {
                    id=Id;
                }
                else
                {
                    throw new Exception("Id should be greater than zero");
                }
            }
            
        }
        public string Employee_id()
        {
            return "Employee Id is: "+id;
        }
    }
}