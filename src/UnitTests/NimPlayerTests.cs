using NUnit.Framework;
using _6_Diff_Nim_Player;

namespace UnitTests
{
    [TestFixture]
    class NimPlayerTests
    {
        [Test]
        public void WhenHeapsZeroHeapEmptyIsTrue()
        {
            NimPlayer.Reset();
            Assert.AreEqual(0, NimPlayer.HeapA);
            Assert.AreEqual(0, NimPlayer.HeapB);
            Assert.AreEqual(0, NimPlayer.HeapC);
        }

        [Test]
        public void WhenHeapsNotZeroHeapEmptyIsFalse()
        {
            NimPlayer.Init();
            Assert.IsTrue(NimPlayer.HeapA > 0);
            Assert.IsTrue(NimPlayer.HeapB > 0);
            Assert.IsTrue(NimPlayer.HeapC > 0);
        }
    }
}
