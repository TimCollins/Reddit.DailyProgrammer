using System;
using System.Collections.Generic;

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
            EventController.Events = new List<Event>(); 

            while (input != 0)
            {
                DisplayMenu();
                DisplayPrompt();

                ConsoleKeyInfo cki = Console.ReadKey(true);                
                input = Convert.ToInt32(cki.KeyChar) - 48;
                ParseInput(input);
            }
        }

        private static void ParseInput(int input)
        {
            switch (input)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    EventController.CreateEvent();
                    break;
                case 2:
                    EventController.ViewEvents();
                    break;
                case 3:
                    EventController.EditEvent();
                    break;
                case 4:
                    EventController.DeleteEvent();
                    break;
                default:
                    Console.WriteLine("{0} is an unsupported option. Please try again.", input);
                    break;
            }
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

        private static void DisplayPrompt()
        {
            Console.Write("> ");
        }
    }
}
