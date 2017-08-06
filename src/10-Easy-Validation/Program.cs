using System;
using Util;

namespace _10_Easy_Validation
{
    /// <summary>
    /// The exercise today asks you to validate a telephone number, as if written 
    /// on an input form. Telephone numbers can be written as ten digits, or with 
    /// dashes, spaces, or dots between the three segments, or with the area code 
    /// parenthesized; both the area code and any white space between segments 
    /// are optional.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new PhoneNumberValidator();
            var input = "(((123)))+(230).{1234}";
            var res = validator.Validate(input);
            Console.WriteLine("{0} returned {1}", input, res);

            ConsoleUtils.WaitForEscape();
        }
    }
}
