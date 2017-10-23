﻿using NUnit.Framework;
using _8_Int_Numbers_To_English;

namespace UnitTests
{
    [TestFixture]
    class NumbersToEnglishTests
    {
        [Test]
        public void CanDoSingleNumberLowest()
        {
            string output = NumberConverter.Convert(0);

            Assert.AreEqual("zero", output);
        }

        [Test]
        public void CanDoSingleNumberLow()
        {
            string output = NumberConverter.Convert(1);

            Assert.AreEqual("one", output);
        }

        [Test]
        public void CanDoSingleNumberHigh()
        {
            string output = NumberConverter.Convert(19);

            Assert.AreEqual("nineteen", output);
        }

        [Test]
        public void CanReturnTwentyFive()
        {
            string output = NumberConverter.Convert(25);

            Assert.AreEqual("twenty five", output);
        }

        [Test]
        public void CanReturnFortyTwo()
        {
            string output = NumberConverter.Convert(42);

            Assert.AreEqual("forty two", output);
        }

        [Test]
        public void CanReturnFifty()
        {
            var output = NumberConverter.Convert(50);
            Assert.AreEqual("fifty", output);
        }

        [Test]
        public void CanReturnSixtySix()
        {
            string output = NumberConverter.Convert(66);

            Assert.AreEqual("sixty six", output);
        }

        [Test]
        public void CanReturnNinetyNine()
        {
            string output = NumberConverter.Convert(99);

            Assert.AreEqual("ninety nine", output);
        }

        [Test]
        public void CanReturnOneHundred()
        {
            string output = NumberConverter.Convert(100);

            Assert.AreEqual("one hundred", output);
        }

        [Test]
        public void CanReturnOneHundredAndFive()
        {
            string output = NumberConverter.Convert(105);

            Assert.AreEqual("one hundred and five", output);
        }

        [Test]
        public void CanReturnTwoHundredAndFiftySix()
        {
            string output = NumberConverter.Convert(256);

            Assert.AreEqual("two hundred and fifty six", output);
        }

        [Test]
        public void CanReturnNineHundredAndNinetyEight()
        {
            string output = NumberConverter.Convert(998);

            Assert.AreEqual("nine hundred and ninety eight", output);
        }

        [Test]
        public void CanReturnNineHundredAndNinetyNine()
        {
            string output = NumberConverter.Convert(999);

            Assert.AreEqual("nine hundred and ninety nine", output);
        }

        [Test]
        public void CanReturnOneThousand()
        {
            string output = NumberConverter.Convert(1000);

            Assert.AreEqual("one thousand", output);
        }

        [Test]
        public void CanReturnOneThousandAndTwentyFour()
        {
            string output = NumberConverter.Convert(1024);

            Assert.AreEqual("one thousand and twenty four", output);
        }

        [Test]
        public void CanReturnNineThousandNineHundredAndNinetyNine()
        {
            string output = NumberConverter.Convert(9999);

            Assert.AreEqual("nine thousand nine hundred and ninety nine", output);
        }

        [Test]
        public void VerifyRedditTest1()
        {
            string output = NumberConverter.Convert(1211);

            Assert.AreEqual("one thousand two hundred and eleven", output);
        }
    }
}
