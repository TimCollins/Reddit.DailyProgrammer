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
    }
}
