using System;
using System.Collections.Generic;

namespace _12_Int_Factors
{
    public class FactorCalculator
    {
        public List<int> GetFactors(int number)
        {
            var factors = new List<int>();
            // Loop to the square root (rounded) of the number
            var max = (int)Math.Sqrt(number);

            for (var factor = 1; factor <= max; ++factor)
            {
                // If the remainder is 0 then add it to the list
                // and also add
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }

            factors.Sort();

            return factors;
        }
    }
}
