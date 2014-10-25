using NUnit.Framework;
using _6_Int_Remove_Dup;

namespace UnitTests
{
    [TestFixture]
    class DuplicatesRemovalTests
    {
        [Test]
        public void VerifyNoDuplicatesLeavesStringUnchanged()
        {
            string output = DuplicateRemover.Remove("hello");

            Assert.AreEqual("hello", output);
        }

        [Test]
        public void VerifySimpleOutput()
        {
            string output = DuplicateRemover.Remove("hellohello");

            Assert.AreEqual("hello", output);
        }

        [Test]
        public void VerifyShortStringsAreUnchanged()
        {
            string output = DuplicateRemover.Remove("he");

            Assert.AreEqual("he", output);
        }

        [Test]
        public void NullStringReturnsEmptyString()
        {
            string output = DuplicateRemover.Remove(null);

            Assert.IsEmpty(output);
        }

        [Test]
        public void EmptyStringReturnsEmptyString()
        {
            string output = DuplicateRemover.Remove(string.Empty);

            Assert.IsEmpty(output);
        }

        [Test]
        public void VerifyThreeCharMatchIsHandled()
        {
            string output = DuplicateRemover.Remove("helhel");

            Assert.AreEqual("hel", output);
        }

        //[Test]
        //public void VerifyMultipleDuplicatesAreRemoved()
        //{
        //    string output = DuplicateRemover.Remove("hellohellohello");

        //    Assert.AreEqual("hello", output);
        //}

        //[Test]
        //public void VerifyMultipleDifferentDuplicatesAreRemoved()
        //{
        //    string output = DuplicateRemover.Remove("aaatestBlaBlatestBlaBla");

        //    // The second occurrence of "test" and the third and fourth occurrences of "Bla" 
        //    // should be removed.

        //    Assert.AreEqual("aaatestBlaBla", output);
        //}
    }
}
