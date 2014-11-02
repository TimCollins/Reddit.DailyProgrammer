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

            return CalcPascal(x - (y - 1), y);
        }

        private static int CalcPascal(int x, int y)
        {
            if (x == 1 || y == 1)
            {
                return 1;
            }

            return CalcPascal(x, y - 1) + CalcPascal(x - 1, y);
        }

        public static void ShowPascal(int height)
        {
            const int width = 80;
            const int fieldWidth = 5;

            for (int i = 1; i <= height; i++)
            {
                Console.Write(new string(' ', (width / 2) - (fieldWidth * i / 2)));

                for (int j = 1; j <= i; j++)
                {
                    string output = "" + GetValueFromCoOrdinates(i, j);
                    output = output.PadRight(fieldWidth);

                    Console.Write(output);
                }

                Console.WriteLine();
            }
        }
    }
}
