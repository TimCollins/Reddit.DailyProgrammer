using System;
using Util;

namespace _3_Int_Cipher
{
    /// <summary>
    /// Create a program that can take a piece of text and encrypt it with an alphabetical 
    /// substitution cipher. This can ignore white space, numbers, and symbols.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHeader();

            //Console.Write("Please enter some text to encrypt: ");
            //string input = Console.ReadLine();

            //Console.Write("Please enter a passphrase: ");
            //string passPhrase = Console.ReadLine();

            // For testing
            string input = "FREDMCFRED";
            string passPhrase = "ZXCV";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // Take chars from passphrase, remove repeated chars and prepend them to 
            // the alphabet string. Remove the letters used in the pass phrase from the
            // alphabet string.
            string cypherbet = "ZXCVABDEFGHIJKLMNOPQRSTUWY";

            Console.Write("Encrypted text: ");
            string encrypted = Cipher.Encrypt(input, alphabet, cypherbet);
            Console.WriteLine(encrypted);

            Console.Write("Decrypted text: ");
            Console.WriteLine(Cipher.Decrypt(encrypted, cypherbet, alphabet));

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("This is an implementation of an alphabetic substitution cipher.");
        }
    }
}
