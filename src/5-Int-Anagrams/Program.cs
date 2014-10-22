﻿using System;
using System.Collections.Generic;
using System.Linq;
using Util;

namespace _5_Int_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string fileName = "mlkdream.txt";
            const string fileName = "usdeclar.txt";
            DisplayHeader();

            List<string> sourceWords = AnagramFinder.GetWordsFromFile(fileName);

            // For testing
            //List<string> sourceWords = new List<string>
            //{
            //    "snap",
            //    "pans",
            //    "stake",
            //    "takes"
            //};

            List<Anagram> output = AnagramFinder.FindAnagrams(sourceWords);
            ShowAnagrams(output);

            ConsoleUtils.WaitForEscape();
        }

        private static void ShowAnagrams(IReadOnlyCollection<Anagram> output)
        {
            Console.WriteLine("There were {0} matches found: ", output.Count);
            foreach (Anagram anagram in output)
            {
                Console.WriteLine("{0} matches {1}", anagram.First, anagram.Second);
            }
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("This program will search a text file for anagrams.");
        }
    }
}
