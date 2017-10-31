using System;
using System.Linq;

namespace _11_Int_Upside_Up
{
    public class UpsideUpCalculator
    {
        public int GetNextAfter(int start)
        {
            return 1;
        }

        public int GetTotal(int max)
        {
            return 1;
        }

        public bool IsUpsideUp(int input)
        {
            // 1961, 689, 0690 should succeed
            // 2017 should fail
            // These digits can be flipped:
            // 1 => 1
            // 6 => 9
            // 8 => 8
            // 9 => 6
            // 0 => 0
            // Note that 6 and 9 don't produce the same result as 1, 8, 0 
            // so they need to be handled differently

            var digits = input.ToString().ToCharArray();
            var reversed = digits.Reverse().ToArray();

            // Switch 6 and 9 in the reversed array
            // Input: 1961
            // Reversed: 1691
            // Switch 6s and 9s: 1961
            // Check equality with input
            // Note that this won't work for single digits.
            for (var i = 0; i < reversed.Length; i++)
            {
                var digit = reversed[i];

                if (!CanFlip(digit))
                {
                    return false;
                }

                if (digit == '6')
                {
                    reversed[i] = '9';
                }
                else if (digit == '9')
                {
                    reversed[i] = '6';
                }
            }

            if (digits.Length == 1)
            {
                if (digits[0] == '6')
                {
                    return reversed[0] == '9';
                }

                if (digits[0] == '9')
                {
                    return reversed[0] == '6';
                }
            }

            return new string(digits) == new string(reversed);
        }

        private bool CanFlip(char digit)
        {
            var number = (int) char.GetNumericValue(digit);
            var canFlip = new[] { 1, 6, 8, 9, 0 };

            return canFlip.Contains(number);
        }
    }
}
