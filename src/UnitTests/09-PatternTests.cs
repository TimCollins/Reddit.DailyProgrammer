using NUnit.Framework;
using _9_Hard_Pattern;

namespace UnitTests
{
    [TestFixture]
    class _09_PatternTests
    {
        [Test]
        public void InitialIterationIs1()
        {
            var result = PatternGenerator.Calculate(1);

            Assert.AreEqual("1", result);
        }

        [Test]
        public void SecondIterationIs11()
        {
            var result = PatternGenerator.Calculate(2);

            Assert.AreEqual("11", result);
        }

        [Test]
        public void ThirdIterationIs21()
        {
            var result = PatternGenerator.Calculate(3);

            Assert.AreEqual("21", result);
        }

        [Test]
        public void FourthIterationIs1211()
        {
            var result = PatternGenerator.Calculate(4);

            Assert.AreEqual("1211", result);
        }

        [Test]
        public void Test8Is1113213211()
        {
            var result = PatternGenerator.Calculate(8);

            Assert.AreEqual("1113213211", result);
        }
    }
}
