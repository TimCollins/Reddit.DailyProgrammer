using System;

namespace _6_Diff_Nim_Player
{
    public static class NimPlayer
    {
        public static int HeapA { get; set; }
        public static int HeapB { get; set; }
        public static int HeapC { get; set; }
        
        private static readonly Random _random = new Random();

        public static bool HeapsEmpty()
        {
            return HeapA == 0 && HeapB == 0 && HeapC == 0;
        }

        public static void DoMove(string heap, int quantity)
        {
            if (heap == "A")
            {
                HeapA -= quantity;
                return;
            }

            if (heap == "B")
            {
                HeapB -= quantity;
                return;
            }

            if (heap == "C")
            {
                HeapC -= quantity;
                return;
            }
        }

        public static string PickHeap()
        {
            bool validChoice = false;
            int r = -1;

            while (!validChoice)
            {
                r = _random.Next(0, 3);
                validChoice = ValidateHeap(r);
            }

            if (r == 0)
            {
                return "A";
            }

            return r == 1 ? "B" : "C";

        }

        private static bool ValidateHeap(int heap)
        {
            if (heap == 0 && HeapA == 0)
            {
                return false;
            }

            if (heap == 1 && HeapB == 0)
            {
                return false;
            }

            if (heap == 2 && HeapC == 0)
            {
                return false;
            }

            return true;
        }

        public static int PickQuantity(string heap)
        {
            if (heap == "A")
            {
                return _random.Next(1, HeapA + 1);
            }

            if (heap == "B")
            {
                return _random.Next(1, HeapB + 1);
            }

            return _random.Next(1, HeapC + 1);
        }

        public static void Init()
        {
            HeapA = 3;
            HeapB = 4;
            HeapC = 5;
        }

        public static void Reset()
        {
            HeapA = 0;
            HeapB = 0;
            HeapC = 0;
        }
    }
}
