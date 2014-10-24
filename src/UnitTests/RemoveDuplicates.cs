using NUnit.Framework;
using _6_Int_Remove_Dup;

namespace UnitTests
{
    [TestFixture]
    class RemoveDuplicates
    {
        [Test]
        public void VerifyOutput()
        {
            string output = DuplicateRemover.Remove("aaatestBlaBlatestBlaBla");

            Assert.AreEqual("aaatestBlaBla", output);
        }
    }
}
