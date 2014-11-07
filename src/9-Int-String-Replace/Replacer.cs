using System.Collections.Generic;
using System.IO;

namespace _9_Int_String_Replace
{
    public static class Replacer
    {
        public static int Replace(string fileName, string searchString, string replaceString)
        {
            List<string> lines = ReadLines(fileName);
            int replaceCount = 0;

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains(searchString))
                {
                    lines[i] = lines[i].Replace(searchString, replaceString);
                    replaceCount++;
                }
            }

            SaveLines(lines);

            return replaceCount;
        }

        private static void SaveLines(IEnumerable<string> lines)
        {
            string fileName = Directory.GetCurrentDirectory() + "\\output.txt";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string line in lines)
                {
                    sw.Write(line);    
                }
            }
        }

        private static List<string> ReadLines(string fileName)
        {
            List<string> lines =new List<string>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    lines.Add(line);
                }
            }

            return lines;
        }
    }
}
