﻿using NUnit.Framework;
using _7_Easy_Morse_Code_Translate;

namespace UnitTests
{
    [TestFixture]
    class MorseCodeTranslatorTests
    {
        [Test]
        public void CanTranslateSimpleInputToMorse()
        {
            const string input = "ABC";

            string output = MorseCodeTranslator.ToMorse(input);

            Assert.AreEqual(".- -... -.-.", output);
        }

        [Test]
        public void CanTranslateMoreToASCII()
        {
            const string input = ".- -... -.-.";

            string output = MorseCodeTranslator.ToASCII(input);

            Assert.AreEqual("ABC", output);
        }
    }
}
