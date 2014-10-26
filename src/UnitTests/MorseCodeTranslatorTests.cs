using NUnit.Framework;
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
        public void CanTranslateMorseToASCII()
        {
            const string input = ".- -... -.-.";

            string output = MorseCodeTranslator.ToASCII(input);

            Assert.AreEqual("ABC", output);
        }

        [Test]
        public void EndOfAlphabetTestToMorse()
        {
            const string input = "XYZ";

            string output = MorseCodeTranslator.ToMorse(input);

            Assert.AreEqual("-..- -.-- --..", output);
        }

        [Test]
        public void EndOfAlphabetTestToASCII()
        {
            const string input = "-..- -.-- --..";

            string output = MorseCodeTranslator.ToASCII(input);

            Assert.AreEqual("XYZ", output);
        }

        [Test]
        public void CanTranslateTwoWordsToASCII()
        {
            const string input = ".... .. / - .... . .-. .";

            string output = MorseCodeTranslator.ToASCII(input);

            Assert.AreEqual("HI THERE", output);
        }

        [Test]
        public void CanTranslateThreeWordsToASCII()
        {
            const string input = ".... .. / - .... . .-. . / .... ..";

            string output = MorseCodeTranslator.ToASCII(input);

            Assert.AreEqual("HI THERE HI", output);
        }

        [Test]
        public void CanTranslateTwoWordsToMorse()
        {
            const string input = "HI THERE";

            string output = MorseCodeTranslator.ToMorse(input);

            Assert.AreEqual(".... .. / - .... . .-. .", output);
        }

        [Test]
        public void CanTranslateThreeWordsToMorse()
        {
            const string input = "HI THERE HI";

            string output = MorseCodeTranslator.ToMorse(input);

            Assert.AreEqual(".... .. / - .... . .-. . / .... ..", output);
        }

        [Test]
        public void RedditMorseToASCII()
        {
            const string input = ".... . .-.. .-.. --- / -.. .- .. .-.. -.-- / .--. .-. --- --. .-. .- -- -- . .-. / --. --- --- -.. / .-.. ..- -.-. -.- / --- -. / - .... . / -.-. .... .- .-.. .-.. . -. --. . ... / - --- -.. .- -.--";
            string output = MorseCodeTranslator.ToASCII(input);

            Assert.AreEqual("HELLO DAILY PROGRAMMER GOOD LUCK ON THE CHALLENGES TODAY", output);
        }
    }
}
