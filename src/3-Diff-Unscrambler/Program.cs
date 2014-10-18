using System;
using System.Collections.Generic;
using System.IO;
using Util;

namespace _3_Diff_Unscrambler
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pkwgf/2112012_challenge_3_difficult/
    /// For this challenge, you need to write a program that will take the scrambled words from 
    /// this post, and compare them against THIS WORD LIST to unscramble them. For bonus 
    /// points, sort the words by length when you are finished.
    /// </summary>
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

            //List<string> words = new List<string>
            //{
            //    "mkeart",
            //    "sleewa",
            //    "edcudls",
            //    "iragoge",
            //    "usrlsle",
            //    "nalraoci",
            //    "nsdeuto",
            //    "amrhat",
            //    "inknsy",
            //    "iferkna"
            //};

            //List<string> source = new List<string>();

            //using (StreamReader sr = new StreamReader(fileName))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        source.Add(sr.ReadLine());
            //    }
            //}

            //source = new List<string>(source.OrderBy(s => s));

            // For testing
            List<string> scrambledWords = new List<string>
            {
                "derf",
                "act",
                "odg"
            };

            List<string> unscrambledWords = new List<string>
            {
                "fred",
                "cat",
                "dog"
            };

            List<string> output = Unscramble(scrambledWords, unscrambledWords);

            for (int i = 0; i < output.Count; i++)
            {
                Console.WriteLine("Scrambled {0} matches unscrambled {1}", scrambledWords[i], unscrambledWords[i]);
            }

            ConsoleUtils.WaitForEscape();
        }

        public static List<string> Unscramble(List<string> scrambledWords, List<string> unscrambledWords)
        {
            // Make this private when the algorithm to use has been figued out.
            List<string> words = new List<string>();

            // Compare length of each word in source.
            // If matched then check that each letter in the source word can be found in a 
            // sorted word. Output the sorted word to an array in the same position as the 
            // unsorted word so that we can say unsorted[i] == sorted[i]

            foreach (string s in scrambledWords)
            {
                for (int i = 0; i < unscrambledWords.Count; i++)
                {
                    if (s.Length == unscrambledWords[i].Length)
                    {
                        if (DoWordsMatch(s, unscrambledWords[i]))
                        {
                            words.Add(unscrambledWords[i]);
                        }
                    }
                }
            }

            return words;
        }

        private static bool DoWordsMatch(string scrambledWord, string unscrambledWord)
        {
            foreach (char c in scrambledWord)
            {
                if (!unscrambledWord.Contains(c.ToString()))
                    return false;
            }

            return true;
        }
    }
}
