using System;
using System.Collections.Generic;
using Util;

namespace SemanticVersionSort
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/2igfj9/10062014_challenge_183_easy_semantic_version_sort/
    /// The full specification for Semantic Versioning can be found here: http://semver.org/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Setup test input
            List<SemanticVersionEntity> inputData = GetTestData();

            // Sort it
            List<SemanticVersionEntity> sortedData = SemanticVersionSorter.Sort(inputData);

            // Output it
            ShowDetails(sortedData);

            ConsoleUtils.WaitForEscape();
        }

        private static void ShowDetails(List<SemanticVersionEntity> sortedData)
        {
            for (int i = 0; i < sortedData.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, sortedData[i]);
            }
        }

        private static List<SemanticVersionEntity> GetTestData()
        {
            return new List<SemanticVersionEntity>
            {
                new SemanticVersionEntity
                {
                    Major = 7
                },
                new SemanticVersionEntity
                {
                    Major = 2,
                    Minor = 0,
                    Patch = 11,
                    Label = "alpha"
                },
                new SemanticVersionEntity
                {
                    Major = 0,
                    Minor = 1,
                    Patch = 7,
                    Label = "amd64"
                },
                new SemanticVersionEntity
                {
                    Major = 0,
                    Minor = 10,
                    Patch = 7,
                    Label = "20141005"
                },
                new SemanticVersionEntity
                {
                    Major = 2,
                    Minor = 0,
                    Patch = 12,
                    Label = "i386"
                },
                new SemanticVersionEntity
                {
                    Major = 1,
                    Minor = 2,
                    Patch = 34
                },
                new SemanticVersionEntity
                {
                    Major = 2,
                    Minor = 0,
                    Patch = 11,
                    Label = "i386"
                },
                new SemanticVersionEntity
                {
                    Major = 20,
                    Minor = 1,
                    Patch = 1,
                    Label = "i386"
                }
            };
        }
    }
}
