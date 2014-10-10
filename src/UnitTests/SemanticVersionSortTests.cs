using System;
using System.Collections.Generic;
using NUnit.Framework;
using SemanticVersionSort;

namespace UnitTests
{
    [TestFixture]
    public class SemanticVersionSortTests
    {
        [Test]
        public void ZeroLengthInputThrowsException()
        {
            var inputData = new List<SemanticVersionEntity>();

            Assert.Throws<ArgumentException>(() => SemanticVersionSorter.Sort(inputData));
        }

        [Test]
        public void OneItemReturnsThatItem()
        {
            var inputData = new List<SemanticVersionEntity>
            {
                new SemanticVersionEntity
                {
                    Major = 2
                }
            };

            var output = SemanticVersionSorter.Sort(inputData);

            Assert.AreEqual(1, output.Count);
            Assert.AreEqual(2, output[0].Major);
        }

        [Test]
        public void VerifyTwoItemComparisonAgainstMajor()
        {
            var inputData = new List<SemanticVersionEntity>
            {
                new SemanticVersionEntity {Major = 3},
                new SemanticVersionEntity {Major = 2},
            };

            var output = SemanticVersionSorter.Sort(inputData);

            Assert.AreEqual(2, output.Count);
            Assert.AreEqual(2, output[0].Major);
            Assert.AreEqual(3, output[1].Major);
        }
    }
}
