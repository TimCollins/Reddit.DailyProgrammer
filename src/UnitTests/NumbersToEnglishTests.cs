using NUnit.Framework;
using _8_Int_Numbers_To_English;

namespace UnitTests
{
    [TestFixture]
    class NumbersToEnglishTests
    {
        [Test]
        public void CanDoSingleNumber()
        {
            string output = NumberConverter.Convert(1);

            Assert.AreEqual("one", output);
        }
    }
}
