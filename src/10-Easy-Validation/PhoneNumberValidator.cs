namespace _10_Easy_Validation
{
    public class PhoneNumberValidator
    {
        public bool Validate(string input)
        {
            int i;
            if (input.Length < 10)
            {
                return false;
            }

            if (int.TryParse(input, out i) && input.Length == 10)
            {
                // Check for all numeric
                return true;
            }

            // Split into groups
            if (input.Length < 12)
            {
                return false;
            }

            // 123-456-7890
            var firstGroup = input.Substring(0, 3);
            var secondGroup = input.Substring(4, 3);
            var thirdGroup = input.Substring(8, 4);

            if (int.TryParse(firstGroup, out i) && int.TryParse(secondGroup, out i) &&
                int.TryParse(thirdGroup, out i))
            {
                return true;
            }

            if (input[0] == '(')
            {
                firstGroup = input.Substring(0, 5).Substring(1, 3);
                secondGroup = input.Substring(input.Length - 8, 3);
                thirdGroup = input.Substring(input.Length - 4, 4);

                if (int.TryParse(firstGroup, out i) && int.TryParse(secondGroup, out i) &&
                    int.TryParse(thirdGroup, out i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
