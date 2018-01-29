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
                // If the remainder is 0 then add the factor to the list
                // and also add the inverse e.g. starting with 1 so that always gets added
                // but also add (number / 1) which is just the number itself
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    {
                        factors.Add(number / factor);
                    }
                }
            }

            return factors;
        }
    }
}
