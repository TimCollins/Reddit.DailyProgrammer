using System;
using NUnit.Framework;
using _13_Easy_DayNumber;

namespace UnitTests
{
    [TestFixture]
    public class _13_DayNumberTests
    {
        private DayNumberCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DayNumberCalculator();    
        }

        [Test]
        public void January1ShouldReturn1()
        {
            const string input = "2018/1/1";
            var output = _calculator.GetDayNumber(input);

            Assert.AreEqual(1, output);
        }

        [Test]
        public void December31ShouldReturn365()
        {
            const string input = "2018/12/31";
            var output = _calculator.GetDayNumber(input);

            Assert.AreEqual(365, output);
        }

        [Test]
        public void DayNumberShouldWorkForPreviousYear()
        {
            const string input = "2017/12/31";
            var output = _calculator.GetDayNumber(input);

            Assert.AreEqual(365, output);
        }

        [Test]
        public void InvalidDateStringShouldDisplayError()
        {
            const string input = "2018/1";
            Assert.Throws<ApplicationException>(() => _calculator.GetDayNumber(input));
        }

        [Test]
        public void InvalidDateFormatStringShouldDisplayError()
        {
            const string input = "2018/1/57";
            Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.GetDayNumber(input));
        }

        [Test]
        public void EmptyStringShouldSomething()
        {
            Assert.Throws<ApplicationException>(() => _calculator.GetDayNumber(string.Empty));
        }
    }
}
