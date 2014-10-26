using System.Collections.Generic;
using System.Text;

namespace _7_Easy_Morse_Code_Translate
{
    public static class MorseCodeTranslator
    {
        // Need something representing the code for each letter/number
        private static List<MorseCodeLetter> MorseCodeAlphabet = new List<MorseCodeLetter>
        {
            new MorseCodeLetter
            {
                ASCIILetter = 'A',
                MorseCodeChars = ".-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'B',
                MorseCodeChars = "-..."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'C',
                MorseCodeChars = "-.-."
            }
        };

        public static string ToASCII(string morseInput)
        {
            StringBuilder output = new StringBuilder();

            // Each morse code letter should be delimited by a space.

            string[] morseLetters = morseInput.Split(' ');

            foreach (string s in morseLetters)
            {
                for (int i = 0; i < MorseCodeAlphabet.Count; i++)
                {
                    MorseCodeLetter morseCodeLetter = MorseCodeAlphabet[i];

                    if (morseCodeLetter.MorseCodeChars == s)
                    {
                        output.Append(morseCodeLetter.ASCIILetter);
                        break;
                    }
                }
            }

            return output.ToString();
        }

        public static string ToMorse(string input)
        {
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                for (int i = 0; i < MorseCodeAlphabet.Count; i++)
                {
                    MorseCodeLetter morseCodeLetter = MorseCodeAlphabet[i];

                    if (morseCodeLetter.ASCIILetter == c)
                    {
                        output.Append(morseCodeLetter.MorseCodeChars);

                        if (i < MorseCodeAlphabet.Count - 1)
                        {
                            output.Append(" ");
                        }
                        break;
                    }
                }
            }

            return output.ToString();
        }
    }
}
