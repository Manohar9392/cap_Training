using System;
using System.Collections.Generic;
using System.Linq;

namespace Gym_Management
{
    public static class GymManager
    {
        private static List<Member> members = new List<Member>();
        private static List<FitnessClass> classes = new List<FitnessClass>();
        private static int memberIdCounter = 1;

        // Add new member
        public static void AddMember(string name, string membershipType, int months)
        {
            members.Add(new Member(memberIdCounter++, name, membershipType, months));
        }

        // Add fitness class
        public static void AddClass(string className, string instructor, DateTime schedule, int maxParticipants)
        {
            classes.Add(new FitnessClass
            {
                ClassName = className,
                Instructor = instructor,
                Schedule = schedule,
                MaxParticipants = maxParticipants
            });
        }

        // Register member for class
        public static bool RegisterForClass(int memberId, string className)
        {
            var fitnessClass = classes.FirstOrDefault(c => c.ClassName == className);

            if (fitnessClass == null || fitnessClass.RegisteredMembers.Count >= fitnessClass.MaxParticipants)
                return false;

            fitnessClass.RegisteredMembers.Add(memberId);
            return true;
        }

        // Group members by membership type
        public static Dictionary<string, List<Member>> GroupMembersByMembershipType()
        {
            return members.GroupBy(m => m.MembershipType)
                          .ToDictionary(g => g.Key, g => g.ToList());
        }

        // Upcoming classes (next 7 days)
        public static List<FitnessClass> GetUpcomingClasses()
        {
            DateTime now = DateTime.Now;
            return classes.Where(c => c.Schedule >= now && c.Schedule <= now.AddDays(7)).ToList();
        }
    }
}
