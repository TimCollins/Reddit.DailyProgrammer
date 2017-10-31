using NUnit.Framework;
using _11_Int_Upside_Up;

namespace UnitTests
{
    [TestFixture]
    public class UpsideUpNumbersTests
    {
        private UpsideUpCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new UpsideUpCalculator();
        }

        [Test]
        public void SupportedSingleDigitsShouldSucceed()
        {
            int[] input = { 1, 6, 8, 9, 0 };

            foreach (var i in input)
            {
                Assert.IsTrue(_calculator.IsUpsideUp(i));
            }
        }

        [Test]
        public void UnsupportedSingleDigitsShouldFail()
        {
            int[] input = { 2, 3, 4, 5, 7 };

            foreach (var i in input)
            {
                Assert.IsFalse(_calculator.IsUpsideUp(i));
            }
        }

        [Test]
        public void DoubleDigitTest()
        {
            var input = 11;

            Assert.IsTrue(_calculator.IsUpsideUp(input));
        }

        [Test]
        public void ShouldSucceed1961()
        {
            const int input = 1961;

            Assert.IsTrue(_calculator.IsUpsideUp(input));
        }
    }
}
