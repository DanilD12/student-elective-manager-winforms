using System;

namespace CourseWork
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string ToFileLine()
        {
            return $"{Login};{Password}";
        }

        public static User FromFileLine(string line)
        {
            string[] parts = line.Split(';');

            if (parts.Length != 2)
                throw new Exception("Некорректная строка пользователя.");

            return new User
            {
                Login = parts[0],
                Password = parts[1]
            };
        }
    }
}