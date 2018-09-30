using NUnit.Framework;
using _14_Easy;

namespace UnitTests
{
    [TestFixture]
    public class BlockTests
    {
        private BlockProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new BlockProcessor();
        }

        [Test]
        public void ShouldReturnZeroElementsIfZeroElementsInput()
        {
            var res = _processor.DoSort(new int[0], 5);

            Assert.AreEqual(0, res.Length);
        }

        [Test]
        public void ShouldReturnZeroElementsIfZeroBlockSizeInput()
        {
            var res = _processor.DoSort(new int[1], 0);

            Assert.AreEqual(0, res.Length);
        }

        [Test]
        public void ShouldReturnZeroElementsIfBlockSizeNotGreaterThanOne()
        {
            var res = _processor.DoSort(new int[1], 1);

            Assert.AreEqual(0, res.Length);
        }

        [Test]
        public void ShouldReturnZeroElementsIfBlockSizeGreaterThanInputLength()
        {
            var input = new[] { 2, 4, 6 };
            var res = _processor.DoSort(input, 4);

            Assert.AreEqual(0, res.Length);
        }

        [Test]
        public void ShouldReturnReversedArrayWhenBlockSizeEqualToInputLength()
        {
            var input = new[] { 2, 4, 6 };
            var res = _processor.DoSort(input, 3);
            var expected = new[] { 6, 4, 2 };

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ShouldReverseSmallList()
        {
            var input = new[] { 2, 4 };
            var expected = new[] { 4, 2 };

            var res = _processor.DoSort(input, 2);

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ShouldReverseElements()
        {
            var input = new[] {24, 12, 32, 44, 55, 66};
            var expected = new[] {24, 12, 44, 32, 66, 55};

            var res = _processor.DoSort(input, 2);

            Assert.AreEqual(expected, res);
        }

        [Test]
        public void ShouldReverseArrayWithOneBlock()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var expected = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var res = _processor.DoSort(input, 9);

            Assert.AreEqual(expected, res);
        }
    }
}
