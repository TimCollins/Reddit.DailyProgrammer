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
        public void WhenInputContainsInvalidCharsExceptionIsThrown()
        {
            Assert.Throws<ArgumentException>(() => NumCombo.ParseInput("2, F, 4"));
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

        [Test]
        public void VerifyParseInputSortsInput()
        {
            const string input = "2,4,3";

            List<int> output = NumCombo.ParseInput(input);

            Assert.AreEqual(3, output.Count);
            Assert.AreEqual(2, output[0]);
            Assert.AreEqual(3, output[1]);
            Assert.AreEqual(4, output[2]);
        }

        [Test]
        public void VerifyOutput()
        {
            const string input = "5, 3, 15";

            List<string> output = NumCombo.FindRelations(NumCombo.ParseInput(input));

            Assert.AreEqual(4, output.Count);
            Assert.AreEqual("3 * 5 = 15", output[0]);
            Assert.AreEqual("5 * 3 = 15", output[1]);
            Assert.AreEqual("15 / 5 = 3", output[2]);
            Assert.AreEqual("15 / 3 = 5", output[3]);
        }
    }
}
