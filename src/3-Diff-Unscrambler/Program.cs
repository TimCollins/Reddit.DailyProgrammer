using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Util;

namespace _3_Diff_Unscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Directory.GetCurrentDirectory() + "\\wordlist.txt";
            // Open wordlist.txt
            // Read each line into a List (source)
            // Sort list by length?
            // For each string in words:
            
            // Something??

            List<string> words = new List<string>
            {
                "mkeart",
                "sleewa",
                "edcudls",
                "iragoge",
                "usrlsle",
                "nalraoci",
                "nsdeuto",
                "amrhat",
                "inknsy",
                "iferkna"
            };

            List<string> source = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    source.Add(sr.ReadLine());
                }
            }

            source = new List<string>(source.OrderBy(s => s));

            foreach (string s in words)
            {
                Unscramble(s, source);
            }

            ConsoleUtils.WaitForEscape();
        }

        private static void Unscramble(string s, List<string> source)
        {
            // Compare length of each word in source.
            // If matched

            for (int i = 0; i < source.Count; i++)
            {
                if (s.Length == source[i].Length)
                {
                    // Do some funky rearranging of the letters to establish if
                    // s and source[i] are the same.
                }
            }
        }
    }
}
