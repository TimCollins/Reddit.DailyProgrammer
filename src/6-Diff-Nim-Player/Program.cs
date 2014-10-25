using System;
using Util;

namespace _6_Diff_Nim_Player
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pp7vo/2142012_challenge_6_difficult/
    /// Create an AI that will play NIM (http://en.wikipedia.org/wiki/Nim).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayStartText();

            Init();
            
            bool done = false;
            bool aiMove = false;

            while (!done)
            {
                ShowHeapDetails();
                if (aiMove)
                {
                    // Computer move.
                    // Pick a random heap
                    string aiHeap = NimPlayer.PickHeap();                    
                    // Pick a random quantity
                    int aiQuantity = NimPlayer.PickQuantity(aiHeap);
                    NimPlayer.DoMove(aiHeap, aiQuantity);

                    Console.WriteLine("AI takes {0} from Heap {1}", aiQuantity, aiHeap);
                    aiMove = false;
                }
                else
                {
                    // Human move
                    ShowPrompt();
                    string input = Console.ReadLine();

                    string heap = input.Substring(0, 1);
                    int quantity = Convert.ToInt32(input.Substring(1, 1));

                    NimPlayer.DoMove(heap.ToUpper(), quantity);

                    aiMove = true;
                }

                if (NimPlayer.HeapsEmpty())
                {
                    done = true;
                }
            }

            Console.WriteLine("Done.");
            ConsoleUtils.WaitForEscape();
        }

        private static void ShowHeapDetails()
        {
            Console.WriteLine("A: {0}\tB: {1}\tC: {2}", NimPlayer.HeapA, NimPlayer.HeapB, NimPlayer.HeapC);
        }

        private static void ShowPrompt()
        {
            Console.Write("Enter heap and quantity e.g. \"A1\":");
        }

        private static void Init()
        {
            NimPlayer.HeapA = 3;
            NimPlayer.HeapB = 4;
            NimPlayer.HeapC = 5;
        }


        private static void DisplayStartText()
        {
            Console.WriteLine("This program will play Nim.");
        }
    }
}
