using NUnit.Framework;
using _14_Int_Sieve;

namespace UnitTests
{
    [TestFixture]
    public class _14_Sieve_Tests
    {
        private Sieve _sieve;

        [SetUp]
        public void Setup()
        {
            _sieve = new Sieve();
        }

        [Test]
        public void ShouldReturnZeroElementsIfZeroSpecified()
        {
            var res = _sieve.CalculatePrimes(0);

            Assert.AreEqual(0, res.Length);
        }

        [Test]
        public void ShouldReturnZeroElementsIfNegativeBoundSpecified()
        {
            var res = _sieve.CalculatePrimes(-2);

            Assert.AreEqual(0, res.Length);
        }

        [Test]
        public void ShouldCalculateCorrectPrimesLessThanTen()
        {
            var res = _sieve.CalculatePrimes(10);
            var expected = new[] {2, 3, 5, 7};

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ShouldFormatArrayCorrectly()
        {
            var res = _sieve.CalculatePrimes(10);
            var expected = _sieve.FormatPrimes(res);
            Assert.AreEqual("2, 3, 5, 7", expected);
        }
    }
}
