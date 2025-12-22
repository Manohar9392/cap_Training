using System;
namespace Chaining_Constructers
{
    public class Login_history
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Requirement;

        public string Log_History{get;set;}

        public Login_history()
        {
            Login_history+=$"Object created on {DateTime.Now.ToString()} /n";
        }
        public Login_history(int id):this()
        {
            Login_history+=$"Id created on {DateTime.Now.ToString()} /n";
            this.Id=id;
            
        }
        public Login_history(int id,string name):this(id)
        {
            Login_history+=$"Name created on {DateTime.Now.ToString()} /n";
            this.Name=name;
        }
        public Login_history(int id,string name,string requirement):this(id,name)
        {
            Login_history+=$"Requirement created on {DateTime.Now.ToString()} /n";
            this.Requirement=requirement;
        }
        public void Display()
        {
            Console.WriteLine("Id: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Requirement: "+Requirement); 
            Console.WriteLine("Log History: "+Log_History);
        }
    }
}