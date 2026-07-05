using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork
{
    public class Student
    {
        public string FullName { get; set; }
        public string GroupNumber { get; set; }
        public double AverageGrade { get; set; }

        public bool Math { get; set; }
        public bool Physics { get; set; }
        public bool Programming { get; set; }
        public bool English { get; set; }
        public bool Databases { get; set; }

        public string SubjectsText
        {
            get
            {
                var subjects = new List<string>();
                if (Math) subjects.Add("Математика");
                if (Physics) subjects.Add("Физика");
                if (Programming) subjects.Add("Программирование");
                if (English) subjects.Add("Английский язык");
                if (Databases) subjects.Add("Базы данных");
                return string.Join(", ", subjects);
            }
        }

        public string ToFileLine()
        {
            return $"{FullName};{GroupNumber};{AverageGrade:F2};" +
                   $"{(Math ? 1 : 0)};{(Physics ? 1 : 0)};{(Programming ? 1 : 0)};" +
                   $"{(English ? 1 : 0)};{(Databases ? 1 : 0)}";
        }

        public static Student FromFileLine(string line)
        {
            var parts = line.Split(';');
            if (parts.Length != 8)
                throw new Exception("Некорректная строка данных.");

            return new Student
            {
                FullName = parts[0],
                GroupNumber = parts[1],
                AverageGrade = double.Parse(parts[2].Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture),
                Math = parts[3] == "1",
                Physics = parts[4] == "1",
                Programming = parts[5] == "1",
                English = parts[6] == "1",
                Databases = parts[7] == "1"
            };
        }
        public int SubjectsCount
        {
            get
            {
                int count = 0;
                if (Math) count++;
                if (Physics) count++;
                if (Programming) count++;
                if (English) count++;
                if (Databases) count++;
                return count;
            }
        }

        public bool HasSubject(string subject)
        {
            switch (subject)
            {
                case "Математика": return Math;
                case "Физика": return Physics;
                case "Программирование": return Programming;
                case "Английский язык": return English;
                case "Базы данных": return Databases;
                default: return false;
            }
        }
    }
}