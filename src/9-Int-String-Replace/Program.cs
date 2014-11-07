using System;
using System.IO;
using Util;

namespace _9_Int_String_Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Directory.GetCurrentDirectory() + "\\mlkdream.txt";

            Console.WriteLine("Enter string to search for.");
            Console.Write("> ");
            string searchString = Console.ReadLine();

            Console.WriteLine("Enter string to replace.");
            Console.Write("> ");
            string replaceString = Console.ReadLine();

            int replaceCount = Replacer.Replace(fileName, searchString, replaceString);

            Console.WriteLine("Replaced {0} occurrences of {1} in {2} with {3}.", replaceCount, searchString, fileName, replaceString);

            ConsoleUtils.WaitForEscape();
        }
    }
}
