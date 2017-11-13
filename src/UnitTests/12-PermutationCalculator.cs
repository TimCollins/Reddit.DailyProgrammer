using NUnit.Framework;
using _12_Easy_Permutations;

namespace UnitTests
{
    [TestFixture]
    public class _12_PermutationCalculator
    {
        private PermutationCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new PermutationCalculator();
        }

        [Test]
        public void Something()
        {
            var input = "A";
            var result = _calculator.Get(input);

            Assert.IsTrue(result.Length == 1);
            Assert.AreEqual(result[0], input);
        }
    }
}
