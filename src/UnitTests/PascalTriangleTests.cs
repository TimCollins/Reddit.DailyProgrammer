using System;
using NUnit.Framework;
using _8_Diff_Pascal_Triangle;

namespace UnitTests
{
    [TestFixture]
    class PascalTriangleTests
    {
        [Test]
        public void CanHandleInvalidInput()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PascalTriangleCalculator.GetValueFromCoOrdinates(1, 19));
        }

        [Test]
        public void RedditTestCase1()
        {
            const int x = 1;
            const int y = 1;

            int output = PascalTriangleCalculator.GetValueFromCoOrdinates(x, y);

            Assert.AreEqual(1, output);
        }

        [Test]
        public void RedditTestCase2()
        {
            const int x = 4;
            const int y = 2;

            int output = PascalTriangleCalculator.GetValueFromCoOrdinates(x, y);

            Assert.AreEqual(3, output);
        }
    }
}
