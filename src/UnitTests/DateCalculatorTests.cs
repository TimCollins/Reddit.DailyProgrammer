using System;
using NUnit.Framework;
using _2_Easy_Calculator;

namespace UnitTests
{
    [TestFixture]
    class DateCalculatorTests
    {
        [Test]
        public void WhenYearMissingExceptionIsThrown()
        {
            const string badInput = "13/10";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void WhenMonthMissingExceptionIsThrown()
        {
            const string badInput = "13/2010";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void WhenDayMissingExceptionIsThrown()
        {
            const string badInput = "11/2010";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void NegativeInputThrowsException()
        {
            const string badInput = "-13/10/2014";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void ZeroInputThrowsException()
        {
            const string badInput = "13/10/0";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void NonNumericYearIsHandled()
        {
            const string badInput = "13/10/Fred";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void NonNumericMonthIsHandled()
        {
            const string badInput = "13/Fred/2014";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void NonNumericDayIsHandled()
        {
            const string badInput = "Fred/10/2014";
            Assert.Throws<ArgumentException>(() => DateCalculator.GetDateFromString(badInput));
        }

        [Test]
        public void WhenEndLessThanStartExceptionIsThrown()
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(-1);
            Assert.Throws<ArgumentException>(() => DateCalculator.GetWorkingDays(start, end));
        }

        [Test]
        public void WhenEndEqualToStartExceptionIsThrown()
        {
            DateTime start = DateTime.Now;
            DateTime end = start;
            Assert.Throws<ArgumentException>(() => DateCalculator.GetWorkingDays(start, end));
        }
    }
}
