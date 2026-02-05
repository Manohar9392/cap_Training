using System;
using Gym_Management;

namespace Gym_App
{
    class Program
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n=== Gym Membership Management ===");
                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. Add Fitness Class");
                Console.WriteLine("3. Register Member For Class");
                Console.WriteLine("4. View Members By Membership Type");
                Console.WriteLine("5. View Upcoming Classes");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Membership Type: ");
                        string type = Console.ReadLine();

                        Console.Write("Months: ");
                        int months = int.Parse(Console.ReadLine());

                        GymManager.AddMember(name, type, months);
                        Console.WriteLine("Member Added");
                        break;

                    case 2:
                        Console.Write("Class Name: ");
                        string cname = Console.ReadLine();

                        Console.Write("Instructor: ");
                        string instructor = Console.ReadLine();

                        Console.Write("Max Participants: ");
                        int max = int.Parse(Console.ReadLine());

                        GymManager.AddClass(cname, instructor, DateTime.Now.AddDays(2), max);
                        Console.WriteLine("Class Added");
                        break;

                    case 3:
                        Console.Write("Member ID: ");
                        int mid = int.Parse(Console.ReadLine());

                        Console.Write("Class Name: ");
                        string cls = Console.ReadLine();

                        Console.WriteLine(
                            GymManager.RegisterForClass(mid, cls)
                            ? "Registered Successfully"
                            : "Registration Failed");
                        break;

                    case 4:
                        var groups = GymManager.GroupMembersByMembershipType();
                        foreach (var g in groups)
                            Console.WriteLine($"{g.Key} → {g.Value.Count} members");
                        break;

                    case 5:
                        foreach (var c in GymManager.GetUpcomingClasses())
                            Console.WriteLine($"{c.ClassName} on {c.Schedule}");
                        break;
                }

            } while (choice != 0);
        }
    }
}
