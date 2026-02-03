using SchoolApp;
using System.Collections.Generic;
using System.Linq;

namespace SchoolApp
{
    public static class SchoolManager
    {
        static int id = 1;
        public static List<Student> students = new List<Student>();

        public static void AddStudent(string name, string grade)
        {
            students.Add(new Student(id++, name, grade));
        }

        public static void AddGrade(int id, string subject, double grade)
        {
            var s = students.FirstOrDefault(x => x.StudentId == id);
            if (s != null) s.Subjects[subject] = grade;
        }

        public static SortedDictionary<string, List<Student>> GroupStudentsByGradeLevel()
        {
            return new SortedDictionary<string, List<Student>>(
                students.GroupBy(s => s.GradeLevel)
                        .ToDictionary(g => g.Key, g => g.ToList()));
        }

        public static double CalculateStudentAverage(int id)
        {
            return students.First(s => s.StudentId == id).Subjects.Values.Average();
        }

        public static Dictionary<string, double> CalculateSubjectAverages()
        {
            return students
                .SelectMany(s => s.Subjects)
                .GroupBy(x => x.Key)
                .ToDictionary(g => g.Key, g => g.Average(x => x.Value));
        }

        public static List<Student> GetTopPerformers(int count)
        {
            return students
                .OrderByDescending(s => s.Subjects.Values.Average())
                .Take(count)
                .ToList();
        }
    }
}
