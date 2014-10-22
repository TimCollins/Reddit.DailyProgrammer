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
                    string[] wordArray = line.RemoveSpecialCharacters().Split(' ');

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
                            words.Add(new Anagram
                            {
                                First = sourceWords[i],
                                Second = sourceWords[j]
                            });
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
