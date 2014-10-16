using System.Text;

namespace _3_Int_Cipher
{
    class Cipher
    {
        public static string Encrypt(string input, string alphabet, string cypherbet)
        {
            StringBuilder output = new StringBuilder();

            // For each letter in input, find the corresponding letter in cypherbet
            // and append it to output.

            foreach (char c in input)
            {
                //int index = cypherbet.IndexOf(c);
                int index = alphabet.IndexOf(c);
                output.Append(cypherbet[index]);
            }

            return output.ToString();
        }

        public static string Decrypt(string input, string cypherbet, string alphabet)
        {
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                //int index = alphabet.IndexOf(c);
                int index = cypherbet.IndexOf(c);
                output.Append(alphabet[index]);
            }

            return output.ToString();
        }
    }
}
