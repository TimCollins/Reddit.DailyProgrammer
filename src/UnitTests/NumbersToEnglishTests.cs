using NUnit.Framework;
using _8_Int_Numbers_To_English;

namespace UnitTests
{
    [TestFixture]
    class NumbersToEnglishTests
    {
        [Test]
        public void CanDoSingleNumberLow()
        {
            string output = NumberConverter.Convert(1);

            Assert.AreEqual("one", output);
        }

        [Test]
        public void CanDoSingleNumberHigh()
        {
            string output = NumberConverter.Convert(19);

            Assert.AreEqual("nineteen", output);
        }

        [Test]
        public void CanReturnTwentyFive()
        {
            string output = NumberConverter.Convert(25);

            Assert.AreEqual("twenty five", output);
        }

        [Test]
        public void CanReturnFortyTwo()
        {
            string output = NumberConverter.Convert(42);

            Assert.AreEqual("forty two", output);
        }

        [Test]
        public void CanReturnSixtySix()
        {
            string output = NumberConverter.Convert(66);

            Assert.AreEqual("sixty six", output);
        }

        [Test]
        public void CanReturnNinetyNine()
        {
            string output = NumberConverter.Convert(99);

            Assert.AreEqual("ninety nine", output);
        }

    }
}
