using System;
using System.Collections.Generic;

namespace _14_Easy
{
    public class BlockProcessor
    {
        public int[] DoSort(int[] elements, int blockSize)
        {
            if (elements.Length == 0 || blockSize < 2 || blockSize > elements.Length)
            {
                return new int[0];
            }

            var output = new List<int>();

            for (var i = 0; i < elements.Length; i+= blockSize)
            {
                var block = new int[blockSize];
                var index = 0;

                for (var j = i; index < blockSize; j++)
                {
                    block[index] = elements[j];
                    index++;
                }

                Array.Sort(block);
                Array.Reverse(block);
                output.AddRange(block);
            }

            return output.ToArray();
        }
    }
}
