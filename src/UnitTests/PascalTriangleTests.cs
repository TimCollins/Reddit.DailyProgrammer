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
            Assert.Throws<ArgumentOutOfRangeException>(() => PascalTriangleCalculator.GetValueFromCoOrdinates(1, 2));
        }
    }
}
