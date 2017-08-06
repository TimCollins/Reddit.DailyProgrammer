using System;

namespace _10_Easy_Validation
{
    public class PhoneNumberValidator
    {
        public bool Validate(string input)
        {
            int i;
            if (int.TryParse(input, out i))
            {
                // Check for all numeric
                return true;
            }

            return false;
        }
    }
}
