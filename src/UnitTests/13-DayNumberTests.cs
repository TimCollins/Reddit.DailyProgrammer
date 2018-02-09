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
            var input = new DateTime(2018, 1, 1);
            var output = _calculator.GetDayNumber(input);

            Assert.AreEqual(1, output);
        }

        [Test]
        public void December31ShouldReturn365()
        {
            var input = new DateTime(2018, 12, 31);
            var output = _calculator.GetDayNumber(input);

            Assert.AreEqual(365, output);
        }

        [Test]
        public void DayNumberShouldWorkForPreviousYear()
        {
            var input = new DateTime(2017, 12, 31);
            var output = _calculator.GetDayNumber(input);

            Assert.AreEqual(365, output);
        }
    }
}
