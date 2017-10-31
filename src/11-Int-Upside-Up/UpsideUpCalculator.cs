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

            var digits = input.ToString().ToCharArray();
            var reversed = digits.Reverse().ToArray();

            for (int i = 0; i < digits.Length; i++)
            {
                var digit = digits[i];

                if (!CanFlip(digit))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CanFlip(char digit)
        {
            var number = (int) char.GetNumericValue(digit);
            var canFlip = new[] { 1, 6, 8, 9, 0 };

            return canFlip.Contains(number);
        }
    }
}
