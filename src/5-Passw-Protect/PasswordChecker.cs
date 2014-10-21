using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5_Passw_Protect
{
    class PasswordChecker
    {
        public static bool Validate(string username, string password)
        {
            // Open accounts.txt
            // Read user details.
            // Compare against supplied details.
            // If a match is found return true else return false
            string fileName = Environment.CurrentDirectory + "\\accounts.txt";
            List<Account> accounts = new List<Account>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    Account account = new Account
                    {
                        Username = GetNextValidLine(sr),
                        Password = GetNextValidLine(sr), 
                    };

                    accounts.Add(account);
                }
            }

            return accounts.Any(a => a.Username == username && a.Password == password);
        }

        private static string GetNextValidLine(StreamReader sr)
        {
            string line = null;

            while (string.IsNullOrEmpty(line) || line.StartsWith("#"))
            {
                line = sr.ReadLine();
            }

            return line;
        }
    }
}
