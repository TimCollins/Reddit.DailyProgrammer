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
            const int input = 1;

            Assert.IsTrue(_calculator.IsUpsideUp(input));
        }

        [Test]
        public void UnsupportedSingleDigitsShouldFail()
        {
            const int input = 7;

            Assert.IsFalse(_calculator.IsUpsideUp(input));
        }

        [Test]
        public void ShouldSucceed1961()
        {
            const int input = 1961;

            Assert.IsTrue(_calculator.IsUpsideUp(input));
        }
    }
}
