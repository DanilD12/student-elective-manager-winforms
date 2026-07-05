using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseWork
{
    public static class StudentStorage
    {
        public static string FilePath = "students_data.txt";

        public static List<Student> LoadStudents()
        {
            if (!File.Exists(FilePath))
                return new List<Student>();

            return File.ReadAllLines(FilePath)
                       .Where(line => !string.IsNullOrWhiteSpace(line))
                       .Select(Student.FromFileLine)
                       .ToList();
        }

        public static void SaveStudents(List<Student> students)
        {
            File.WriteAllLines(FilePath, students.Select(s => s.ToFileLine()));
        }
    }
}