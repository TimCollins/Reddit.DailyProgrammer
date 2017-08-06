using NUnit.Framework;
using _10_Easy_Validation;

namespace UnitTests
{
    [TestFixture]
    class PhoneValidationTests
    {
        [Test]
        public void AllDigitsShouldBeValid()
        {
            const string input = "1234567890";
            var validator = new PhoneNumberValidator();
            var isValid = validator.Validate(input);

            Assert.IsTrue(isValid);
        }
    }
}
