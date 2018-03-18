using System;

namespace _14_Hard_ThreadedSort
{
    public class ThreadedSort
    {
        //private const int SizeLimit = 1000000;
        private const int SizeLimit = 100;
        private const int NumberLimit = 1000;
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
            BubbleSort();
        }

        private void BubbleSort()
        {
            var length = _numbers.Length;
            bool swapHasTakenPlace;

            do
            {
                swapHasTakenPlace = false;

                for (var i = 1; i < length; i++)
                {
                    if (_numbers[i - 1] > _numbers[i])
                    {
                        var tmp = _numbers[i - 1];
                        _numbers[i - 1] = _numbers[i];
                        _numbers[i] = tmp;
                        swapHasTakenPlace = true;
                    }
                }
            } while (swapHasTakenPlace);
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
