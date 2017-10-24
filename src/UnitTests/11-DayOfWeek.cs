using NUnit.Framework;
using _11_Easy_DayOfWeek;

namespace UnitTests
{
    [TestFixture]
    public class DayOfWeekTests
    {
        private DayOfWeekCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DayOfWeekCalculator();
        }
        // Test the first arg to be from 0 - 6 inclusive
        // The the second to be from 0 - 11 inclusive
        // The third to be from 1970 - 2038 inclusive
        [Test]
        public void LessThanThreeArgsWillFail()
        {
            var args = new[] { "first", "second" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MoreThanThreeArgsWillFail()
        {
            var args = new[] { "first", "second", "third", "fourth" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void ExactlyThreeArgsWillPass()
        {
            var args = new[] { "1", "2", "3" };

            Assert.IsTrue(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void DayMustBeNumeric()
        {
            var args = new[] { "a", "5", "1997" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void DayLessThanZeroWillFail()
        {
            var args = new[] { "-2", "5", "1997" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void DayGreaterThanSixShouldFail()
        {
            var args = new[] { "17", "5", "1997" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MonthMustBeNumeric()
        {
            var args = new[] { "5", "b", "1997" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MonthLessThanZeroWillFail()
        {
            var args = new[] { "2", "-5", "1997" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MonthGreaterThanElevenShouldFail()
        {
            var args = new[] { "1", "15", "1997" };

            Assert.IsFalse(_calculator.IsValidCommandLine(args));
        }

    }
}
