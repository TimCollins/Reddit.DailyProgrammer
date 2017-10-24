using NUnit.Framework;
using _11_Easy_DayOfWeek;

namespace UnitTests
{
    [TestFixture]
    public class DayOfWeekTests
    {
        // Tests: args < 3, args > 3
        // Test the first arg to be from 0 - 6 inclusive
        // The the second to be from 0 - 11 inclusive
        // The third to be from 1970 - 2038 inclusive
        [Test]
        public void LessThanThreeArgsWillFail()
        {
            var calculator = new DayOfWeekCalculator();
            var args = new[] {"first", "second"};

            Assert.IsFalse(calculator.IsValidCommandLine(args));
        }

        [Test]
        public void MoreThanThreeArgsWillFail()
        {
            var calculator = new DayOfWeekCalculator();
            var args = new[] { "first", "second", "third", "fourth" };

            Assert.IsFalse(calculator.IsValidCommandLine(args));
        }

        [Test]
        public void ExactlyThreeArgsWillPass()
        {
            var calculator = new DayOfWeekCalculator();
            var args = new[] { "first", "second", "third" };

            Assert.IsTrue(calculator.IsValidCommandLine(args));
        }
    }
}
