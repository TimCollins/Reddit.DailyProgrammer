using System;
using Util;

namespace _1_Int_EventMenu
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pihtx/intermediate_challenge_1/
    /// Create a menu driven program
    /// Using the menu drive program allow a user to add/delete items
    /// The menu should be based on an events calender where users enter the events by hour
    /// No events should be hard-coded.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;

            while (input != 0)
            {
                DisplayMenu();
                input = Convert.ToInt32(Console.ReadLine());
                ParseInput(input);
            }

            // TODO: Create an app-wide object to store event details by date and time.
            // The CRUD operations should operate on that object.
        }

        private static void ParseInput(int input)
        {
            switch (input)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    CreateEvent();
                    break;
                default:
                    throw new ArgumentException("input");
            }
        }

        private static void CreateEvent()
        {
            throw new NotImplementedException();
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("This program will allow you to schedule events by hour on specified days.");
            Console.WriteLine("1 - Create Event\n" +
                              "2 - View Events\n" +
                              "3 - Edit Event\n" +
                              "4 - Remove Event\n" +
                              "0 - Exit Program");
        }
    }
}
