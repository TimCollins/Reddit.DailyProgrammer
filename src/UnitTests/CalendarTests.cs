using NUnit.Framework;
using _11_Hard_Calendar;

namespace UnitTests
{
    [TestFixture]
    public class CalendarTests
    {
        private CalendarGenerator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new CalendarGenerator();
        }

        // Check for format "-m1 -y2017"

        [Test]
        public void LessThanTwoArgsShouldFail()
        {
            var args = new[] { "First" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void TwoArgsShouldSucceed()
        {
            var args = new[] { "-m11", "-y2017" };

            Assert.IsTrue(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MoreThanTwoArgsShouldFail()
        {
            var args = new[] { "First", "Second", "Third" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void IncorrectFormatMonthParamShouldFail()
        {
            var args = new[] { "1", "-y2017" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MissingMonthParamShouldFail()
        {
            var args = new[] { "-m", "-y2017" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void NonNumericMonthParamShouldFail()
        {
            var args = new[] { "-mFred", "-y2017" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void InvalidMonthParamShouldFail()
        {
            var args = new[] { "-m14", "-y2017" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }
    }
}
