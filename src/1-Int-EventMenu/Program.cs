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
        public static List<Event> Events; 

        static void Main(string[] args)
        {
            int input = -1;
            Events = new List<Event>(); 

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
                    CreateEvent();
                    break;
                case 2:
                    ViewEvents();
                    break;
                case 3:
                    EditEvent();
                    break;
                case 4:
                    DeleteEvent();
                    break;
                default:
                    Console.WriteLine("{0} is an unsupported option. Please try again.", input);
                    break;
            }
        }

        private static void DeleteEvent()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("\nThere are no events in the system yet.");
                return;
            }

            Console.Write("Enter ID of event to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Events.RemoveAt(id);

            Console.WriteLine("Event deleted.");
        }

        private static void EditEvent()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("\nThere are no events in the system yet.");
                return;
            }

            Console.Write("Enter ID of event to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Events.RemoveAt(id);

        }

        private static void ViewEvents()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("\nThere are no events in the system yet.");
                return;
            }

            Console.WriteLine("\nThere are {0} events in the system.", Events.Count);

            foreach (Event e in Events)
            {
                ShowEventDetails(e);
            }

            Console.WriteLine("\n");
        }

        private static void ShowEventDetails(Event e)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Date: {2}", e.ID, e.Name, e.Date);
        }

        private static void CreateEvent()
        {
            Console.WriteLine("Creating a new event.");
            
            Event e = new Event
            {
                ID = Events.Count + 1
            };

            Console.Write("Enter event name: ");
            e.Name = Console.ReadLine();

            Console.Write("Enter event date (dd/mm/yyyy): ");
            string date = Console.ReadLine();

            Console.Write("Enter event start time hour (0-23): ");
            string hour = Console.ReadLine();

            // Make a date out of the two strings.
            e.Date = ParseStringsAsDate(date, hour);

            Events.Add(e);
        }

        private static DateTime ParseStringsAsDate(string date, string hour)
        {
            string[] parts = date.Split('/');
            DateTime d = new DateTime(Convert.ToInt32(parts[2]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[0]), Convert.ToInt32(hour), 0, 0);

            return d;
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
