using NUnit.Framework;
using _9_Hard_Pattern;

namespace UnitTests
{
    [TestFixture]
    class _09_PatternTests
    {
        [Test]
        public void OtherMethod()
        {
            var result = PatternGenerator.Calculate("1");

            Assert.AreEqual("11", result);
        }
    }
}
