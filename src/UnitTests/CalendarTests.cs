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
            var args = new[] { "First", "Second" };

            Assert.IsTrue(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MoreThanTwoArgsShouldFail()
        {
            var args = new[] { "First", "Second", "Third" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }


    }
}
