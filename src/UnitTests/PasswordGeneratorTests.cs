using System.Collections.Generic;
using NUnit.Framework;
using _4_Easy_Password;

namespace UnitTests
{
    [TestFixture]
    class PasswordGeneratorTests
    {
        [Test]
        public void CorrectNumberOfPasswordsIsGenerated()
        {
            List<string> output = PasswordGenerator.GeneratePasswords(2, 5);

            Assert.AreEqual(2, output.Count);
        }

        [Test]
        public void PasswordsAreOfSpecifiedLength()
        {
            List<string> output = PasswordGenerator.GeneratePasswords(3, 6);

            foreach (string s in output)
            {
                Assert.AreEqual(6, s.Length);
            }
        }

        [Test]
        public void ZeroPasswordCountIsHandled()
        {
            List<string> output = PasswordGenerator.GeneratePasswords(0, 5);

            Assert.AreEqual(0, output.Count);
        }

        [Test]
        public void ZeroPasswordLengthIsHandled()
        {
            List<string> output = PasswordGenerator.GeneratePasswords(5, 0);

            foreach (string s in output)
            {
                Assert.AreEqual(0, s.Length);
            }
        }
    }
}
