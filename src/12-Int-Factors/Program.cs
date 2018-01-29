using System;
using System.Text;
using Util;

namespace _12_Int_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            const int input = 12;
            var factors = new FactorCalculator().GetFactors(input);
            var output = new StringBuilder(string.Format("{0} = ", input));

            foreach (var i in factors)
            {
                output.Append(string.Format("{0} * ", i));
            }

            Console.WriteLine(output.ToString());
            ConsoleUtils.WaitForEscape();
        }
    }
}
