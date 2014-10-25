namespace _6_Diff_Nim_Player
{
    class NimPlayer
    {
        public static int HeapA { get; set; }
        public static int HeapB { get; set; }
        public static int HeapC { get; set; }

        public static bool HeapsEmpty()
        {
            return HeapA == 0 && HeapB == 0 && HeapC == 0;
        }
    }
}
