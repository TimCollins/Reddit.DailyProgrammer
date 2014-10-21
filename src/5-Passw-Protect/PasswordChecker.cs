using System;
using System.Collections.Generic;
using System.IO;

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
                        Username = sr.ReadLine(), 
                        Password = sr.ReadLine()
                    };

                    //string line = sr.ReadLine();
                    //while (line.StartsWith("#"))
                    //{
                    //    line = sr.ReadLine();
                    //}

                    accounts.Add(account);
                }
            }

            foreach (Account account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
