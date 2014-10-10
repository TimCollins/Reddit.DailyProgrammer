using System;
using System.Collections.Generic;

namespace SemanticVersionSort
{
    public static class SemanticVersionSorter
    {
        public static List<SemanticVersionEntity> Sort(List<SemanticVersionEntity> source)
        {
            if (source.Count == 0)
            {
                throw new ArgumentException("source");
            }

            // Initial (probably awful) implementation of a bubble sort
            // Loop through each element.
            // Compare it against each of the others using the sorting rules above, 
            // Swapping the elements as needed.

            for (int i = source.Count - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (source[j + 1] < source[j])
                    {
                        var tmp = source[j + 1];
                        source[j + 1] = source[j];
                        source[j] = tmp;
                    }
                }
            }

            return source;
        }
    }
}
