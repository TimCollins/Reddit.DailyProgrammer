using System;
using Util;

namespace _8_Int_Numbers_To_English
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/psewf/2162012_challenge_8_intermediate/
    /// Write a program that will print the english name of a value. For example, "1211" would 
    /// become "one-thousand, two hundred, eleven".
    /// I haven't quite adhered to the proposed number format but it does do what it should.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();
            Console.Write("Value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumberConverter.Convert(value));

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("This program will print the English description of a value.");
        }
    }
}
