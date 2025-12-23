using System;

namespace Chaining_Constructers
{
    public class Login_history
    {
        public int Id { get
            {
                return id;
            }
             set
            {
                id = value;
            } }
        public string? Name { get; set; } 
        public string? Requirement { get; set; }

        public string? Log_History { get; set; } 

        public Login_history()
        {
            Log_History += $"Object created on {DateTime.Now}\n";
        }

        public Login_history(int id) : this()
        {
            Log_History += $"Id created on {DateTime.Now}\n";
            Id = id;
        }

        public Login_history(int id, string name) : this(id)
        {
            Log_History += $"Name created on {DateTime.Now}\n";
            Name = name;
        }

        public Login_history(int id, string name, string requirement) : this(id, name)
        {
            Log_History += $"Requirement created on {DateTime.Now}\n";
            Requirement = requirement;
        }

        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Requirement: " + Requirement);
            Console.WriteLine("Log History:\n" + Log_History);
        }
    }
}
