using NUnit.Framework;
using _3_Int_Cipher;

namespace UnitTests
{
    [TestFixture]
    class AlphabeticalCipherTests
    {
        [Test]
        public void EncryptionIsDone()
        {
            const string input = "FREDMCFRED";
            const string passPhrase = "ZXCV";

            string encrypted = Cipher.Encrypt(input, passPhrase);

            Assert.AreEqual("BOAVJCBOAV", encrypted);
        }

        [Test]
        public void NumbersAreRemovedFromInput()
        {
            const string input = "FRED123";
            const string passPhrase = "ZXCV";

            string encrypted = Cipher.Encrypt(input, passPhrase);

            Assert.AreEqual("BOAV", encrypted);
        }

        [Test]
        public void WhitespaceIsRemovedFromInput()
        {
            const string input = " FRED 123";
            const string passPhrase = "ZXCV";

            string encrypted = Cipher.Encrypt(input, passPhrase);

            Assert.AreEqual("BOAV", encrypted);
        }

        [Test]
        public void InputIsUpperCasedBeforeEncryption()
        {
            const string inputUpper = "FRED";
            const string inputLower = "fred";            
            const string inputMmixed = "fReD";

            const string passPhrase = "ZXCV";

            string encryptedUpper = Cipher.Encrypt(inputUpper, passPhrase);
            string encryptedLower = Cipher.Encrypt(inputLower, passPhrase);
            string encryptedMixed = Cipher.Encrypt(inputMmixed, passPhrase);

            Assert.AreEqual("BOAV", encryptedUpper);
            Assert.AreEqual("BOAV", encryptedLower);
            Assert.AreEqual("BOAV", encryptedMixed);
        }

        [Test]
        public void NonAlphaNumericCharsAreRemoved()
        {
            const string input = "FRED$!^&";
            const string passPhrase = "ZXCV";

            string encrypted = Cipher.Encrypt(input, passPhrase);

            Assert.AreEqual("BOAV", encrypted);
        }

        [Test]
        public void OnlyLettersAllowed()
        {
            const string input = "Fr ED!99^&";
            const string passPhrase = "ZXCV";

            string encrypted = Cipher.Encrypt(input, passPhrase);

            Assert.AreEqual("BOAV", encrypted);
        }

        [Test]
        public void DecryptionIsDone()
        {
            const string input = "BOAVJCBOAV";
            const string passPhrase = "ZXCV";

            string encrypted = Cipher.Decrypt(input, passPhrase);

            Assert.AreEqual("FREDMCFRED", encrypted);
        }

        // Add the readlines() back in.
    }
}
