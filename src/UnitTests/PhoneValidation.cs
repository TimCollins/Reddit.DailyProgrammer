using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    class PhoneValidation
    {
        [Test]
        public void AllDigitsShouldBeValid()
        {
            const string input = "1234567890";
            var isValid = PhoneNumberValidator.Validate(input);

            Assert.IsTrue(isValid);
        }
    }
}
