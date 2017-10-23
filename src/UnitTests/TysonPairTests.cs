using NUnit.Framework;
using _10_Int_TysonPairs;

namespace UnitTests
{
    [TestFixture]
    class TysonPairTests
    {
        [Test]
        public void ValuesThatDoNotMatchShouldReturnFalse()
        {
            var first = "1 + 1";
            var second = "2 + 2";
            
            Assert.IsFalse(new TysonPairChecker().IsPair(first, second));
        }

        [Test]
        public void TwelvePlusOneShouldMatch()
        {
            var first = "12 + 1";
            var second = "11 + 2";

            Assert.IsTrue(new TysonPairChecker().IsPair(first, second));
        }

        [Test]
        public void FourPlusTwentySevenShouldMatch()
        {
            var first = "4 + 27 ";
            var second = "7 + 24";

            Assert.IsTrue(new TysonPairChecker().IsPair(first, second));
        }

        [Test]
        public void FortyNinePlusTwentyOneShouldMatch()
        {
            var first = "49 + 27";
            var second = "27 + 49";

            Assert.IsTrue(new TysonPairChecker().IsPair(first, second));
        }
    }
}
