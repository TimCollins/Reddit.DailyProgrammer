using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Easy_Morse_Code_Translate
{
    public static class MorseCodeTranslator
    {
        #region MorseCode Alphabet Declaration
        private static readonly List<MorseCodeLetter> MorseCodeAlphabet = new List<MorseCodeLetter>
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
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'D',
                MorseCodeChars = "-.."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'E',
                MorseCodeChars = "."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'F',
                MorseCodeChars = "..-."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'G',
                MorseCodeChars = "--."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'H',
                MorseCodeChars = "...."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'I',
                MorseCodeChars = ".."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'J',
                MorseCodeChars = ".---"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'K',
                MorseCodeChars = "-.-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'L',
                MorseCodeChars = ".-.."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'M',
                MorseCodeChars = "--"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'N',
                MorseCodeChars = "-."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'O',
                MorseCodeChars = "---"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'P',
                MorseCodeChars = ".--."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'Q',
                MorseCodeChars = "--.-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'R',
                MorseCodeChars = ".-."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'S',
                MorseCodeChars = "..."
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'T',
                MorseCodeChars = "-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'U',
                MorseCodeChars = "..-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'V',
                MorseCodeChars = "...-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'W',
                MorseCodeChars = ".--"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'X',
                MorseCodeChars = "-..-"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'Y',
                MorseCodeChars = "-.--"
            },
            new MorseCodeLetter
            {
                ASCIILetter = 'Z',
                MorseCodeChars = "--.."
            }
        };
        #endregion

        public static string ToASCII(string morseInput)
        {
            StringBuilder output = new StringBuilder();

            // Each morse code letter should be delimited by a space.
            // Each word is delimited by " / "

            string[] morseWords = morseInput.Split(new[] {" / "}, StringSplitOptions.None);
            int wordCnt = 0;
            foreach (string word in morseWords)
            {
                string[] morseLetters = word.Split(' ');
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
                wordCnt++;
                if (wordCnt < morseWords.Length)
                {
                    output.Append(" ");
                }
            }

            return output.ToString();
        }

        public static string ToMorse(string input)
        {
            StringBuilder output = new StringBuilder();

            string[] words = input.Split(' ');
            int wordCnt = 0;

            foreach (string word in words)
            {
                int letterCnt = 0;
                foreach (char c in word)
                {
                    for (int i = 0; i < MorseCodeAlphabet.Count; i++)
                    {
                        MorseCodeLetter morseCodeLetter = MorseCodeAlphabet[i];

                        if (morseCodeLetter.ASCIILetter == c)
                        {
                            output.Append(morseCodeLetter.MorseCodeChars);

                            if (letterCnt < word.Length - 1)
                            {
                                output.Append(" ");
                            }

                            letterCnt++;
                            break;
                        }
                    }
                }

                wordCnt++;
                if (wordCnt < words.Length)
                {
                    output.Append(" / ");
                }
            }

            return output.ToString();
        }
    }
}
