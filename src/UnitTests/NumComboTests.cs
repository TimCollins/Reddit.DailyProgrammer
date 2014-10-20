using System;
using System.Collections.Generic;
using NUnit.Framework;
using _4_Diff_NumCombos;

namespace UnitTests
{
    [TestFixture]
    class NumComboTests
    {
        [Test]
        public void WhenInputIsBlankExceptionIsThrown()
        {
            Assert.Throws<ArgumentException>(() => NumCombo.ParseInput(null));
        }
        [Test]
        public void VerifyParseInputWithSpaces()
        {
            const string input = "2, 3, 4";

            List<int> output = NumCombo.ParseInput(input);

            Assert.AreEqual(3, output.Count);
            Assert.AreEqual(2, output[0]);
            Assert.AreEqual(3, output[1]);
            Assert.AreEqual(4, output[2]);
        }

        [Test]
        public void VerifyParseInputNoSpaces()
        {
            // Given a string like "2,3,4"
            // return a list of just the integers.
            const string input = "2,3,4";

            List<int> output = NumCombo.ParseInput(input);

            Assert.AreEqual(3, output.Count);
            Assert.AreEqual(2, output[0]);
            Assert.AreEqual(3, output[1]);
            Assert.AreEqual(4, output[2]);
        }
    }
}
