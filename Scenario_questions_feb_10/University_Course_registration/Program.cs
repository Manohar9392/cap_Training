using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    // ===================== INTERFACES =====================

    public interface IStudent
    {
        int StudentId { get; }
        string Name { get; }
        int Semester { get; }
    }

    public interface ICourse
    {
        string CourseCode { get; }
        string Title { get; }
        int MaxCapacity { get; }
        int Credits { get; }
    }

    // ===================== ENROLLMENT SYSTEM =====================

    public class EnrollmentSystem<TStudent, TCourse>
        where TStudent : IStudent
        where TCourse : ICourse
    {
        private Dictionary<TCourse, List<TStudent>> _enrollments = new();

        public bool EnrollStudent(TStudent student, TCourse course)
        {
            if (student == null || course == null)
                return false;

            // Prerequisite check (only for LabCourse)
            if (course is LabCourse labCourse)
            {
                if (student.Semester < labCourse.RequiredSemester)
                    return false;
            }

            if (!_enrollments.ContainsKey(course))
                _enrollments[course] = new List<TStudent>();

            if (_enrollments[course].Count >= course.MaxCapacity)
                return false;

            if (_enrollments[course].Contains(student))
                return false;

            _enrollments[course].Add(student);
            return true;
        }

        public IReadOnlyList<TStudent> GetEnrolledStudents(TCourse course)
        {
            if (_enrollments.ContainsKey(course))
                return _enrollments[course].AsReadOnly();

            return new List<TStudent>().AsReadOnly();
        }

        public IEnumerable<TCourse> GetStudentCourses(TStudent student)
        {
            foreach (var entry in _enrollments)
            {
                if (entry.Value.Contains(student))
                    yield return entry.Key;
            }
        }

        public int CalculateStudentWorkload(TStudent student)
        {
            return _enrollments
                .Where(e => e.Value.Contains(student))
                .Sum(e => e.Key.Credits);
        }

        public bool IsStudentEnrolled(TStudent student, TCourse course)
        {
            return _enrollments.ContainsKey(course) &&
                   _enrollments[course].Contains(student);
        }
    }

    // ===================== ENTITIES =====================

    public class EngineeringStudent : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public string Specialization { get; set; }
    }

    public class LabCourse : ICourse
    {
        public string CourseCode { get; set; }
        public string Title { get; set; }
        public int MaxCapacity { get; set; }
        public int Credits { get; set; }
        public string LabEquipment { get; set; }
        public int RequiredSemester { get; set; }
    }

    // ===================== GRADEBOOK =====================

    public class GradeBook<TStudent, TCourse>
        where TStudent : IStudent
        where TCourse : ICourse
    {
        private Dictionary<(TStudent, TCourse), double> _grades
            = new Dictionary<(TStudent, TCourse), double>();

        private EnrollmentSystem<TStudent, TCourse> _enrollmentSystem;

        public GradeBook(EnrollmentSystem<TStudent, TCourse> enrollmentSystem)
        {
            _enrollmentSystem = enrollmentSystem;
        }

        public void AddGrade(TStudent student, TCourse course, double grade)
        {
            if (grade < 0 || grade > 100)
                throw new ArgumentException("Grade must be between 0 and 100");

            if (!_enrollmentSystem.IsStudentEnrolled(student, course))
                throw new InvalidOperationException("Student not enrolled in course");

            _grades[(student, course)] = grade;
        }

        public double? CalculateGPA(TStudent student)
        {
            var studentGrades = _grades
                .Where(g => g.Key.Item1.Equals(student))
                .ToList();

            if (!studentGrades.Any())
                return null;

            double totalWeighted = 0;
            int totalCredits = 0;

            foreach (var entry in studentGrades)
            {
                var course = entry.Key.Item2;
                totalWeighted += entry.Value * course.Credits;
                totalCredits += course.Credits;
            }

            return totalWeighted / totalCredits;
        }

        public (TStudent student, double grade)? GetTopStudent(TCourse course)
        {
            var courseGrades = _grades
                .Where(g => g.Key.Item2.Equals(course))
                .ToList();

            if (!courseGrades.Any())
                return null;

            var top = courseGrades
                .OrderByDescending(g => g.Value)
                .First();

            return (top.Key.Item1, top.Value);
        }
    }

    // ===================== MAIN (SIMULATION) =====================

    class Program
    {
        static void Main()
        {
            var enrollmentSystem =
                new EnrollmentSystem<EngineeringStudent, LabCourse>();

            var gradeBook =
                new GradeBook<EngineeringStudent, LabCourse>(enrollmentSystem);

            // Students
            var s1 = new EngineeringStudent { StudentId = 1, Name = "Alice", Semester = 3 };
            var s2 = new EngineeringStudent { StudentId = 2, Name = "Bob", Semester = 2 };
            var s3 = new EngineeringStudent { StudentId = 3, Name = "Charlie", Semester = 1 };

            // Courses
            var c1 = new LabCourse
            {
                CourseCode = "LAB101",
                Title = "Basic Electronics Lab",
                MaxCapacity = 2,
                Credits = 3,
                RequiredSemester = 2
            };

            var c2 = new LabCourse
            {
                CourseCode = "LAB201",
                Title = "Advanced Circuits Lab",
                MaxCapacity = 1,
                Credits = 4,
                RequiredSemester = 3
            };

            Console.WriteLine("---- Enrollment ----");

            Console.WriteLine($"Alice -> LAB101: {enrollmentSystem.EnrollStudent(s1, c1)}");
            Console.WriteLine($"Bob -> LAB101: {enrollmentSystem.EnrollStudent(s2, c1)}");
            Console.WriteLine($"Charlie -> LAB101: {enrollmentSystem.EnrollStudent(s3, c1)}"); // prerequisite fail
            Console.WriteLine($"Alice -> LAB201: {enrollmentSystem.EnrollStudent(s1, c2)}");
            Console.WriteLine($"Bob -> LAB201: {enrollmentSystem.EnrollStudent(s2, c2)}"); // capacity fail

            Console.WriteLine("\n---- Add Grades ----");

            gradeBook.AddGrade(s1, c1, 85);
            gradeBook.AddGrade(s2, c1, 90);
            gradeBook.AddGrade(s1, c2, 95);

            Console.WriteLine("\n---- GPA ----");

            Console.WriteLine($"Alice GPA: {gradeBook.CalculateGPA(s1)}");
            Console.WriteLine($"Bob GPA: {gradeBook.CalculateGPA(s2)}");

            Console.WriteLine("\n---- Top Students ----");

            var topC1 = gradeBook.GetTopStudent(c1);
            Console.WriteLine($"Top in LAB101: {topC1?.student.Name} - {topC1?.grade}");

            var topC2 = gradeBook.GetTopStudent(c2);
            Console.WriteLine($"Top in LAB201: {topC2?.student.Name} - {topC2?.grade}");
        }
    }
}
