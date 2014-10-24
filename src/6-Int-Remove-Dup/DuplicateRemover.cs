using System.Text;

namespace _6_Int_Remove_Dup
{
    public class DuplicateRemover
    {
        public static string Remove(string input)
        {
            StringBuilder output = new StringBuilder();

            // Split the string in half and compare one half to the other.
            string first = input.Substring(0, input.Length / 2);
            string second = input.Substring(input.Length / 2);

            if (DoWordsMatch(first, second))
            {
                output.Append(first);
            }

            return output.ToString();
        }

        private static bool DoWordsMatch(string first, string second)
        {
            foreach (char c in first)
            {
                if (!second.Contains(c.ToString()))
                    return false;
            }

            foreach (char c in second)
            {
                if (!first.Contains(c.ToString()))
                    return false;
            }

            return true;
        }
    }
}
