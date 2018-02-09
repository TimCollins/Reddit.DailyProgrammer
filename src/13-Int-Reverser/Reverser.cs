using System;
using System.IO;

namespace _13_Int_Reverser
{
    public class Reverser
    {
        public bool IsValidCommandLine(string[] args)
        {
            return args.Length == 1;
        }

        public string Reverse(string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public void Write(string s)
        {
            var filename = Environment.CurrentDirectory + "\\output.txt";

            using (var sw = new StreamWriter(filename))
            {
                sw.Write(s);
            }
        }
    }
}
