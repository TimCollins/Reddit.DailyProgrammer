using NUnit.Framework;
using _3_Easy_Cipher;

namespace UnitTests
{
    [TestFixture]
    class CipherTests
    {
        [Test]
        public void NumbersAreEncrypted()
        {
            const string input = "12345";

            string output = Cipher.Encrypt(input);

            Assert.AreEqual("45678", output);
        }

        [Test]
        public void LowerCaseLettersAreEncrypted()
        {
            const string input = "abcde";

            string output = Cipher.Encrypt(input);

            Assert.AreEqual("defgh", output);
        }

        [Test]
        public void UpperCaseLettersAreEncrypted()
        {
            const string input = "ABCDE";

            string output = Cipher.Encrypt(input);

            Assert.AreEqual("DEFGH", output);
        }

        [Test]
        public void NumbersAreDecrypted()
        {
            const string input = "45678";

            string output = Cipher.Decrypt(input);

            Assert.AreEqual("12345", output);
        }

        [Test]
        public void LowerCaseLettersAreDecrypted()
        {
            const string input = "defgh";

            string output = Cipher.Decrypt(input);

            Assert.AreEqual("abcde", output);
        }

        [Test]
        public void UpperCaseLettersAreDecrypted()
        {
            const string input = "DEFGH";

            string output = Cipher.Decrypt(input);

            Assert.AreEqual("ABCDE", output);
        }

        [Test]
        public void MixOfLowerCaseAndNumbersIsEncrypted()
        {
            const string input = "123zyx";

            string output = Cipher.Encrypt(input);

            Assert.AreEqual("456}|{", output);
        }

        [Test]
        public void MixOfLowerCaseAndNumbersIsDecrypted()
        {
            const string input = "456}|{";

            string output = Cipher.Decrypt(input);

            Assert.AreEqual("123zyx", output);
        }

        [Test]
        public void MixOfUpperCaseAndNumbersIsEncrypted()
        {
            const string input = "X2Y5Z5";

            string output = Cipher.Encrypt(input);

            Assert.AreEqual("[5\\8]8", output);
        }

        [Test]
        public void MixOfUpperCaseAndNumbersIsDecrypted()
        {
            const string input = "[5\\8]8";

            string output = Cipher.Decrypt(input);

            Assert.AreEqual("X2Y5Z5", output);
        }

        [Test]
        public void MixOfUpperCaseAndLowerCaseIsEncrypted()
        {
            const string input = "JFDxow";

            string output = Cipher.Encrypt(input);

            Assert.AreEqual("MIG{rz", output);
        }

        [Test]
        public void MixOfUpperCaseAndLowerCaseIsDecrypted()
        {
            const string input = "MIG{rz";

            string output = Cipher.Decrypt(input);

            Assert.AreEqual("JFDxow", output);
        }

        //[Test]
        //public void NonAlphaNumericCharsIgnoredDuringEncryption()
        //{
        //    const string input = "OGas!£";

        //    string output = Cipher.Encrypt(input);

        //    Assert.AreEqual("MIG{rz", output);
        //}

        //[Test]
        //public void SpaceIsIgnored()
        //{
            
        //}

        // Check uppercase, other punctuation
    }
}
