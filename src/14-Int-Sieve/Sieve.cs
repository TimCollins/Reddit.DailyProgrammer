using System.Collections.Generic;

namespace _14_Int_Sieve
{
    /// <summary>
    /// See https://en.wikipedia.org/wiki/Sieve_of_Sundaram for definition
    /// </summary>
    public class Sieve
    {
        public int[] CalculatePrimes(int upperBound)
        {
            if (upperBound < 1)
            {
                return new int[0];
            }

            var primeFlags = new bool[upperBound];

            for (var i = 2; i < upperBound; i++)
            {
                primeFlags[i] = true;
            }

            for (var i = 2; i < upperBound; i++)
            {
                if (primeFlags[i])
                {
                    for (var p = 2; (p * i) < upperBound; p++)
                    {
                        primeFlags[p * i] = false;
                    }
                }
            }

            var primes = new List<int>();

            for (var i = 0; i < primeFlags.Length; i++)
            {
                if (primeFlags[i])
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }

        public string FormatPrimes(int[] primes)
        {
            return string.Join(", ", primes);
        }
    }
}
