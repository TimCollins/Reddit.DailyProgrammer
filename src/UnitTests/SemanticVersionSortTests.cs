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
                new SemanticVersionEntity {Major = 2}
            };

            var output = SemanticVersionSorter.Sort(inputData);

            Assert.AreEqual(2, output.Count);
            Assert.AreEqual(2, output[0].Major);
            Assert.AreEqual(3, output[1].Major);
        }

        [Test]
        public void VerifyThreeItemComparisonAgainstMajorAndMinor()
        {
            var inputData = new List<SemanticVersionEntity>
            {
                new SemanticVersionEntity {Major = 3, Minor = 6},
                new SemanticVersionEntity {Major = 2, Minor = 2},
                new SemanticVersionEntity {Major = 3, Minor = 4}
            };

            var output = SemanticVersionSorter.Sort(inputData);

            Assert.AreEqual(3, output.Count);
            // Expecting (2, 2), (3, 4), (3, 6)
            Assert.AreEqual(2, output[0].Major);
            Assert.AreEqual(2, output[0].Minor);

            Assert.AreEqual(3, output[1].Major);
            Assert.AreEqual(4, output[1].Minor);

            Assert.AreEqual(3, output[2].Major);
            Assert.AreEqual(6, output[2].Minor);
        }

        [Test]
        public void VerifyFourItemComparisonAgainstMajorMinorAndPatch()
        {
            var inputData = new List<SemanticVersionEntity>
            {
                new SemanticVersionEntity {Major = 3, Minor = 6},
                new SemanticVersionEntity {Major = 5, Minor = 4, Patch = 25},
                new SemanticVersionEntity {Major = 2, Minor = 2, Patch = 15},
                new SemanticVersionEntity {Major = 2, Minor = 2, Patch = 10},
            };

            var output = SemanticVersionSorter.Sort(inputData);

            Assert.AreEqual(4, output.Count);
            // Expecting (2, 2, 10), (2, 2, 15), (3, 6, 0), (5, 4, 25)
            Assert.AreEqual(2, output[0].Major);
            Assert.AreEqual(2, output[0].Minor);
            Assert.AreEqual(10, output[0].Patch);

            Assert.AreEqual(2, output[1].Major);
            Assert.AreEqual(2, output[1].Minor);
            Assert.AreEqual(15, output[1].Patch);

            Assert.AreEqual(3, output[2].Major);
            Assert.AreEqual(6, output[2].Minor);
            Assert.AreEqual(0, output[2].Patch);

            Assert.AreEqual(5, output[3].Major);
            Assert.AreEqual(4, output[3].Minor);
            Assert.AreEqual(25, output[3].Patch);
        }

        [Test]
        public void FiveItemComparisonAgainstAllProperties()
        {
            var inputData = new List<SemanticVersionEntity>
            {
                new SemanticVersionEntity {Major = 3, Minor = 6, Patch = 25},
                new SemanticVersionEntity {Major = 6, Minor = 2, Patch = 15},
                new SemanticVersionEntity {Major = 5, Metadata = "beta"},
                new SemanticVersionEntity {Major = 5, Minor = 2, Patch = 25, Metadata = "alpha"},
                new SemanticVersionEntity {Major = 1, Patch = 6},
            };

            var output = SemanticVersionSorter.Sort(inputData);

            Assert.AreEqual(5, output.Count);

            Assert.AreEqual(1, output[0].Major);
            Assert.AreEqual(0, output[0].Minor);
            Assert.AreEqual(6, output[0].Patch);
            Assert.IsNull(output[0].Metadata);

            Assert.AreEqual(3, output[1].Major);
            Assert.AreEqual(6, output[1].Minor);
            Assert.AreEqual(25, output[1].Patch);
            Assert.IsNull(output[1].Metadata);

            Assert.AreEqual(5, output[2].Major);
            Assert.AreEqual(0, output[2].Minor);
            Assert.AreEqual(0, output[2].Patch);
            Assert.AreEqual("beta", output[2].Metadata);

            Assert.AreEqual(5, output[3].Major);
            Assert.AreEqual(2, output[3].Minor);
            Assert.AreEqual(25, output[3].Patch);
            Assert.AreEqual("alpha", output[3].Metadata);

            Assert.AreEqual(6, output[4].Major);
            Assert.AreEqual(2, output[4].Minor);
            Assert.AreEqual(15, output[4].Patch);
            Assert.IsNull(output[4].Metadata);
        }
    }
}
