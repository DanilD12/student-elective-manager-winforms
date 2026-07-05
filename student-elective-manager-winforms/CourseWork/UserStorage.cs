using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseWork
{
    public static class UserStorage
    {
        public static string FilePath = "users.txt";

        public static List<User> LoadUsers()
        {
            if (!File.Exists(FilePath))
            {
                var defaultUsers = new List<User>
                {
                    new User { Login = "admin", Password = "12345" }
                };

                SaveUsers(defaultUsers);
                return defaultUsers;
            }

            return File.ReadAllLines(FilePath)
                       .Where(line => !string.IsNullOrWhiteSpace(line))
                       .Select(User.FromFileLine)
                       .ToList();
        }

        public static void SaveUsers(List<User> users)
        {
            File.WriteAllLines(FilePath, users.Select(u => u.ToFileLine()));
        }

        public static bool UserExists(string login)
        {
            return LoadUsers().Any(u => u.Login == login);
        }

        public static bool ValidateUser(string login, string password)
        {
            return LoadUsers().Any(u => u.Login == login && u.Password == password);
        }

        public static bool RegisterUser(string login, string password)
        {
            var users = LoadUsers();

            if (users.Any(u => u.Login == login))
                return false;

            users.Add(new User
            {
                Login = login,
                Password = password
            });

            SaveUsers(users);
            return true;
        }
    }
}