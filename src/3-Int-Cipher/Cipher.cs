using System;
using System.Text;

namespace _3_Int_Cipher
{
    public class Cipher
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string Encrypt(string input, string passPhrase)
        {
            string cypherbet = GetCypherbet(passPhrase);
            string validatedInput = Validate(input).ToUpper();
            StringBuilder output = new StringBuilder();

            foreach (char c in validatedInput)
            {
                int index = Alphabet.IndexOf(c);
                output.Append(cypherbet[index]);
            }

            return output.ToString();
        }

        private static string Validate(string input)
        {
            // Strip numbers, space and punctuation.
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {
                    output.Append(c);
                }
            }

            return output.ToString();
        }

        public static string Decrypt(string input, string passPhrase)
        {
            string cypherbet = GetCypherbet(passPhrase);
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                int index = cypherbet.IndexOf(c);
                output.Append(Alphabet[index]);
            }

            return output.ToString();
        }

        private static string GetCypherbet(string passPhrase)
        {
            // Take chars from passphrase, remove repeated chars and prepend them to 
            // the alphabet string. Remove the letters used in the pass phrase from the
            // alphabet string.
            
            string cypherbet = Alphabet;

            foreach (char c in passPhrase)
            {
                int index = cypherbet.IndexOf(c);
                
                if (index > -1)
                {
                    cypherbet = cypherbet.Remove(index, 1);
                }
            }

            return passPhrase + cypherbet;
        }
    }
}
