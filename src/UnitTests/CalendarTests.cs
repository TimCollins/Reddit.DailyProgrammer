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
        public void UnsupportedSwitchShouldFail()
        {
            var args = new[] { "-z11", "-y2017" };

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

        [Test]
        public void IncorrectFormatYearParamShouldFail()
        {
            var args = new[] { "-m11", "2017" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MissingYearParamShouldFail()
        {
            var args = new[] { "-m11", "-y" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void NonNumericYearParamShouldFail()
        {
            var args = new[] { "-m12", "-yBob" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void InvalidYearParamShouldFail()
        {
            var args = new[] { "-m12", "-y2100" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }
    }
}
