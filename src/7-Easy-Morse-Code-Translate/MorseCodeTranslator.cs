using System.Collections.Generic;

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
            return string.Empty;
        }

        public static string ToMorse(string input)
        {
            return string.Empty;
        }
    }
}
