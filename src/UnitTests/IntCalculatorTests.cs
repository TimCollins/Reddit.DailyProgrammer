﻿using NUnit.Framework;
using _4_Int_Calculator;

namespace UnitTests
{
    [TestFixture]
    class IntCalculatorTests
    {
        [Test]
        public void VerifyBasicAddition()
        {
            const string input = "5 + 5";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(10, output);
        }

        [Test]
        public void VerifyBasicDivision()
        {
            const string input = "5 / 5";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(1, output);
        }

        [Test]
        public void VerifyBasicSubtraction()
        {
            const string input = "5 - 5";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(0, output);
        }

        [Test]
        public void VerifyBasicMultiplication()
        {
            const string input = "5 * 5";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(25, output);
        }

        [Test]
        public void VerifyMultiplicationAndAddition()
        {
            const string input = "5 * 5 + 4";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(29, output);
        }

        [Test]
        public void VerifyAdditionAndMultiplication()
        {
            const string input = "5 + 5 * 4";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(25, output);
        }

        [Test]
        public void VerifyAdditionAndSubtraction()
        {
            const string input = "5 + 5 - 4";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(6, output);
        }

        [Test]
        public void VerifyAdditionAndAddition()
        {
            const string input = "5 + 5 + 4";

            int output = Calculator.Calculate(input);

            Assert.AreEqual(14, output);
        }
    }
}
