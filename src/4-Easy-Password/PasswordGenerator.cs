using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Easy_Password
{
    public class PasswordGenerator
    {
        private static readonly Random Random = new Random();
        private const string SourceChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static List<string> GeneratePasswords(int noPasswords, int passwordLength)
        {
            List<string> passwords = new List<string>();

            for (int i = 0; i < noPasswords; i++)
            {
                passwords.Add(GetPassword(passwordLength));
            }

            return passwords;
        }

        private static string GetPassword(int passwordLength)
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < passwordLength; i++)
            {
                int r = Random.Next(0, SourceChars.Length - 1);
                output.Append(SourceChars[r]);
            }

            return output.ToString();
        }
    }
}
