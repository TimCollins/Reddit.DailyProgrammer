using NUnit.Framework;
using _10_Int_TysonPairs;

namespace UnitTests
{
    [TestFixture]
    class TysonPairTests
    {
        [Test]
        public void TwelvePlusOneShouldMatch()
        {
            var first = "12 + 1";
            var second = "11 + 2";

            Assert.IsTrue(new TysonPairChecker().IsPair(first, second));
        }
    }
}
