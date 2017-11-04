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

        [Test]
        public void LessThanTwoArgsShouldFail()
        {
            var args = new[] {"First", "Second"};

            Assert.IsTrue(_calculator.IsValidCommandLine(args));
        }
    }
}
