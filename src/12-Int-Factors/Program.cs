using System;
using System.Text;
using Util;

namespace _12_Int_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to display factors for.\n> ");
            var input = Convert.ToInt32(Console.ReadLine());
            var factors = new FactorCalculator().GetFactors(input);
            factors.Sort();

            var output = new StringBuilder(string.Format("The factors of {0} are: ", input));
            output.Append(string.Join(", ", factors));

            Console.WriteLine(output.ToString());
            // See here for a third-party calculator:
            // http://www.mathwarehouse.com/arithmetic/factorization-calculator.php
            ConsoleUtils.WaitForEscape();
        }
    }
}
