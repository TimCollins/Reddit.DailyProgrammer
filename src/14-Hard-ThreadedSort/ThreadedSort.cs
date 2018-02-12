using System;

namespace _14_Hard_ThreadedSort
{
    public class ThreadedSort
    {
        //private const int SizeLimit = 1000000;
        private const int SizeLimit = 100;
        private const int NumberLimit = 100;
        private int[] _numbers;
        public void Generate()
        {
            _numbers = new int[SizeLimit];
            var r = new Random();

            for (var i = 0; i < SizeLimit; i++)
            {
                _numbers[i] = r.Next(1, NumberLimit);
            }
        }

        public void Sort()
        {
            // throw new System.NotImplementedException();
        }

        public void Display()
        {
            for (var i = 0; i < SizeLimit; i++)
            {
                Console.WriteLine("Index {0} - Number {1}", i, _numbers[i]);
            }
        }
    }
}
