using System;
using System.IO;
using Util;

namespace _1_Easy_Greeting
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pih8x/easy_challenge_1/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will request some information, repeat it and then save it to a file called output.txt");
            
            User user = GetUser();

            DisplayUser(user);

            SaveUser(user);

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayUser(User user)
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nUserName: {2}", user.Name, user.Age, user.UserName);
        }

        private static void SaveUser(User user)
        {
            string filename = Environment.CurrentDirectory + "\\output.txt";

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write("Name: {0}\nAge: {1}\nUserName: {2}", user.Name, user.Age, user.UserName);
            }

            Console.WriteLine("Data written to {0}", filename);
        }

        private static User GetUser()
        {
            User user = new User();
            Console.WriteLine("Please enter your name: ");
            user.Name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            user.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your username: ");
            user.UserName = Console.ReadLine();

            return user;
        }

        private class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string UserName { get; set; }
        }
    }
}
