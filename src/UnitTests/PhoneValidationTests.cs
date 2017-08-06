﻿using NUnit.Framework;
using _10_Easy_Validation;

namespace UnitTests
{
    [TestFixture]
    class PhoneValidationTests
    {
        // These should pass:
        // 1234567890 (10 digits)
        // 123-456-7890 (Separated by dashes into segments)
        // 123.456.7890 (Separated by dots into segments)
        // (123)456-7890
        // (123) 456-7890
        // 456-7890

        // These should fail:
        // 123-45-6789
        // 123:4567890
        // 123/456-7890

        [Test]
        public void AllDigitsShouldBeValid()
        {
            const string input = "1234567890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void LessThan10DigitsShouldBeInvalid()
        {
            const string input = "1234567";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void NotEnoughSeparatorsShouldBeInvalid()
        {
            const string input = "123-4567890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void SegmentsWithDashesShouldBeValid()
        {
            const string input = "123-456-7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void SegmentsWithDotsShouldBeValid()
        {
            const string input = "123.456.7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void BracketsAroundFirstSegmentShouldBeValid()
        {
            const string input = "(123)456.7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void WhitespaceAfterFirstSegmentShouldBeValid()
        {
            const string input = "(123) 456.7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void FirstSegmentShouldBeOptional()
        {
            const string input = "456-7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void AllSpaceSeparatorsShouldBeValid()
        {
            const string input = "123 456 7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void TwoDigitSecondSegmentShouldBeInvalid()
        {
            const string input = "123-45-6789";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void TwoDigitSecondSegmentWithAltSeparatorShouldBeInvalid()
        {
            const string input = "123.45.6789";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void ColonIsNotAValidSeparator()
        {
            const string input = "123:456:7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsFalse(isValid);
        }

        [Test]
        public void SlashIsNotAValidSeparator()
        {
            const string input = "123/456/7890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsFalse(isValid);
        }
    }
}
