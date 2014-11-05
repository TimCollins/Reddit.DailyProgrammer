using System;
using NUnit.Framework;
using _9_Easy_Sorting;

namespace UnitTests
{
    [TestFixture]
    class SortingTests
    {
        [Test]
        public void ExceptionThrownForInvalidData()
        {
            Assert.Throws<ArgumentException>(() => Sorter.Sort(string.Empty));
        }

        [Test]
        public void CanHandleOneDigit()
        {
            const string input = "7";

            string output = Sorter.Sort(input);

            Assert.AreEqual(input, output);
        }

        [Test]
        public void CanHandleTwoDigits()
        {
            const string input = "7, 6";

            string output = Sorter.Sort(input);

            Assert.AreEqual("6, 7", output);
        }

        [Test]
        public void CanHandleTwoDigitsInCorrectOrder()
        {
            const string input = "6, 7";

            string output = Sorter.Sort(input);

            Assert.AreEqual("6, 7", output);
        }

        [Test]
        public void CanHandleMultipleNumbers()
        {
            const string input = "6, 7, 3, 12, -2";

            string output = Sorter.Sort(input);

            Assert.AreEqual("-2, 3, 6, 7, 12", output);
        }
    }
}
