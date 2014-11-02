using System;

namespace _8_Diff_Pascal_Triangle
{
    public static class PascalTriangleCalculator
    {
        public static int GetValueFromCoOrdinates(int x, int y)
        {
            if (y > x)
            {
                throw new ArgumentOutOfRangeException("y");
            }

            return 1;
        }
    }
}
