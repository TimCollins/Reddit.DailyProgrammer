using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Int_EventMenu
{
    public class EventController
    {
        public static List<Event> Events;

        public static void CreateEvent()
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

            if (IsValidEvent(e))
            {
                Events.Add(e);
            }
            else
            {
                Console.WriteLine("The submitted event details are invalid. Please review and try again.");
            }
        }

        public static bool IsValidEvent(Event e)
        {
            throw new NotImplementedException();
        }

        internal static void DeleteEvent()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("\nThere are no events in the system yet.");
                return;
            }

            ShowEventsDetails();

            Console.Write("Enter ID of event to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Events.RemoveAll(e => e.ID == id);

            Console.WriteLine("Event deleted.");
        }

        internal static void ShowEventsDetails()
        {
            foreach (Event e in Events)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Date: {2}", e.ID, e.Name, e.Date);
            }

            Console.WriteLine("\n");
        }

        internal static DateTime ParseStringsAsDate(string date, string hour)
        {
            string[] parts = date.Split('/');
            DateTime d = new DateTime(Convert.ToInt32(parts[2]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[0]), Convert.ToInt32(hour), 0, 0);

            return d;
        }

        internal static void EditEvent()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("\nThere are no events in the system yet.");
                return;
            }

            ShowEventsDetails();

            Console.Write("Enter ID of event to edit: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Event eventToEdit = Events.First(e => e.ID == id);

            Events.RemoveAll(e => e.ID == id);

            GetEventDetails(eventToEdit);
            Events.Add(eventToEdit);
        }

        private static void GetEventDetails(Event e)
        {
            Console.Write("Enter event name: ");
            e.Name = Console.ReadLine();

            Console.Write("Enter event date (dd/mm/yyyy): ");
            string date = Console.ReadLine();

            Console.Write("Enter event start time hour (0-23): ");
            string hour = Console.ReadLine();

            // Make a date out of the two strings.
            e.Date = ParseStringsAsDate(date, hour);
        }

        internal static void ViewEvents()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("\nThere are no events in the system yet.");
                return;
            }

            Console.WriteLine("\nThere are {0} events in the system.", Events.Count);

            ShowEventsDetails();
        }
    }
}
