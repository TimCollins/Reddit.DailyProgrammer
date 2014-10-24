using NUnit.Framework;
using _6_Int_Remove_Dup;

namespace UnitTests
{
    [TestFixture]
    class DuplicatesRemovalTests
    {
        [Test]
        public void VerifySimpleOutput()
        {
            string output = DuplicateRemover.Remove("hellohello");

            Assert.AreEqual("hello", output);
        }

        [Test]
        public void VerifyOutput()
        {
            string output = DuplicateRemover.Remove("aaatestBlaBlatestBlaBla");

            // The second occurrence of "test" and the third and fourth occurrences of "Bla" 
            // should be removed.

            Assert.AreEqual("aaatestBlaBla", output);
        }
    }
}
