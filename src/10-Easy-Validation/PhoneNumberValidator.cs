namespace _10_Easy_Validation
{
    public class PhoneNumberValidator
    {
        public bool Validate(string input)
        {
            int i;
            string firstGroup;
            string secondGroup;
            string thirdGroup;

            // If there are only two groups but the second group has 4 digits then it's valid
            if (input.Length == 8 && input[3] == '-')
            {
                firstGroup = input.Substring(0, 3);
                secondGroup = input.Substring(4, 4);

                if (int.TryParse(firstGroup, out i) && int.TryParse(secondGroup, out i))
                {
                    return true;
                }
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

            // Check the last separator
            var lastSeparator = input.Substring(input.Length - 5, 1)[0];
            if (lastSeparator != ' ' && lastSeparator != '.' && lastSeparator != '-')
            {
                return false;
            }

            // 123-456-7890
            firstGroup = input.Substring(0, 3);
            secondGroup = input.Substring(4, 3);
            thirdGroup = input.Substring(8, 4);

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

            if (input[3] == '-')
            {
                var parts = input.Split('-');
                if (parts[1].Length == 2)
                {
                    return false;
                }
            }

            if (input[3] == '.')
            {
                var parts = input.Split('.');
                if (parts[1].Length == 2)
                {
                    return false;
                }
            }
            
            return false;
        }
    }
}
