namespace _12_Easy_Permutations
{
    public class PermutationCalculator
    {
        public string Get(string prefix, string word)
        {
            var n = word.Length;
            if (n == 0)
            {
                return prefix;
            }

            for (var i = 0; i < n; i++)
            {
                Get(prefix + word[i], word.Substring(0, i) + word.Substring(i + 1, n - (i + 1)));
            }

            return prefix;
        }
    }
}
