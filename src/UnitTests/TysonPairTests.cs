using NUnit.Framework;
using _10_Int_TysonPairs;

namespace UnitTests
{
    [TestFixture]
    class TysonPairTests
    {
        [Test]
        public void TwelvePlusOneShouldSucceed()
        {
            var first = 12;
            var second = 1;

            Assert.IsTrue(new TysonPairChecker().IsPair(first, second));
        }
    }
}
