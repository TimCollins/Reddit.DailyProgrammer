using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using _12_Int_Factors;

namespace UnitTests
{
    [TestFixture]
    public class Factors
    {
        private FactorCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new FactorCalculator();
        }

        [Test]
        public void FactorOfOneIsOne()
        {
            var factors = _calculator.GetFactors(1);

            Assert.AreEqual(1, factors.Count);
            Assert.AreEqual(1, factors[0]);
        }

        [Test]
        public void FactorsOfTwelve()
        {
            var factors = _calculator.GetFactors(12);
            factors.Sort();

            var expected = new List<int> {1, 2, 3, 4, 6, 12};
            // An intersection is a set of elements that are common to both
            var duplicates = factors.Intersect(expected).ToList();
            // Get all factors except those that are in the expected list
            // Obviously this list should have no items
            var distinct = factors.Except(expected).ToList();

            Assert.AreEqual(6, factors.Count);
            Assert.AreEqual(6, duplicates.Count);
            Assert.AreEqual(0, distinct.Count);            
        }
    }
}
