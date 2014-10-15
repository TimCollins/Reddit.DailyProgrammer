using NUnit.Framework;
using _3_Easy_Cipher;

namespace UnitTests
{
    [TestFixture]
    class CipherTests
    {
        [Test]
        public void NumbersAreConverted()
        {
            const string input = "12345";

            string encrypted = Cipher.Encrypt(input);

            Assert.AreEqual("NOPQR", encrypted);
        }

        [Test]
        public void LowerCaseLettersAreConverted()
        {
            const string input = "abcde";

            string encrypted = Cipher.Encrypt(input);

            Assert.AreEqual("defgh", encrypted);
        }

        [Test]
        public void UpperCaseLettersAreConverted()
        {
            const string input = "ABCDE";

            string encrypted = Cipher.Encrypt(input);

            Assert.AreEqual("^_`ab", encrypted);
        }

        //[Test]
        //public void SpaceIsIgnored()
        //{
            
        //}

        // Check uppercase, other punctuation
    }
}
