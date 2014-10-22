using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _5_Int_Anagrams
{
    public static class AnagramFinder
    {
        public static List<string> GetWordsFromFile(string fileName)
        {
            List<string> words = new List<string>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    //string[] wordArray = line.RemoveSpecialCharacters().Split(' ');
                    string[] wordArray = line.Split(' ');

                    foreach (string s in wordArray.Where(s => !words.Contains(s)))
                    {
                        words.Add(s);
                    }
                }
            }

            return words;
        }

        public static List<Anagram> FindAnagrams(List<string> sourceWords)
        {
            List<Anagram> words = new List<Anagram>();

            for (int i = 0; i < sourceWords.Count; i++)
            {
                for (int j = 1; j < sourceWords.Count; j++)
                {
                    if (sourceWords[i].Length == sourceWords[j].Length)
                    {
                        if (DoWordsMatch(sourceWords[i], sourceWords[j]))
                        {
                            Anagram anagram = new Anagram
                            {
                                First = sourceWords[i],
                                Second = sourceWords[j]
                            };

                            if (!words.AlreadyContains(anagram) && sourceWords[i] != sourceWords[j])
                            {
                                words.Add(anagram);
                            }

                            break;
                        }
                    }
                }
            }
            return words;
        }

        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '\'')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static bool AlreadyContains(this List<Anagram> words, Anagram anagram)
        {
            foreach (var w in words)
            {
                if (w.First == anagram.First && w.Second == anagram.Second)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool DoWordsMatch(string first, string second)
        {
            // There's a problem with this function as it stands. The word "secure" will match the
            // word "course" because every letter in the first word is found in the second 
            // (both e chars are matched)
            foreach (char c in first)
            {
                if (!second.Contains(c.ToString()))
                    return false;
            }

            foreach (char c in second)
            {
                if (!first.Contains(c.ToString()))
                    return false;
            }

            return true;
        }
    }
}
