using System;
using System.Collections.Generic;
using System.Diagnostics;
using Util;

namespace _2_Diff_Stopwatch
{
    /// <summary>
    /// See http://www.reddit.com/r/dailyprogrammer/comments/pjsdx/difficult_challenge_2/
    /// Create a stopwatch program. This program should have start, stop, and lap options, 
    /// and it should write out to a file to be viewed later.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            Stopwatch stopWatch = new Stopwatch();
            List<TimeSpan> lapTimes = new List<TimeSpan>();

            // Start a stopwatch
            // Go to 0,0
            // output "Current Time: xxx
            // If keypress == l
            // Write out the current time on a new line as a lap time.
            // Save lap time to a list variable.
            // When Esc is pressed write out all lap times to a file.
            while (!done)
            {
                Console.SetCursorPosition(0, 0);
                TimeSpan ts = stopWatch.Elapsed;

                DisplayHeader(stopWatch.IsRunning);
                DisplayLaps(lapTimes);
                Console.WriteLine("Current Time: " +
                                  string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                      ts.Hours, ts.Minutes, ts.Seconds,
                                      ts.Milliseconds / 10));

                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;

                    if (key == ConsoleKey.Escape)
                    {
                        done = true;
                    }

                    if (key == ConsoleKey.S)
                    {
                        if (stopWatch.IsRunning)
                        {
                            stopWatch.Stop();
                        }
                        else
                        {
                            stopWatch.Start();
                        }
                    }

                    if (key == ConsoleKey.L)
                    {
                        if (stopWatch.IsRunning)
                        {
                            lapTimes.Add(ts);
                        }
                    }
                }

            }

            ConsoleUtils.WaitForEscape();
        }

        private static void DisplayLaps(List<TimeSpan> lapTimes)
        {
            if (lapTimes.Count == 0)
                return;

            for (int i = 0; i < lapTimes.Count; i++)
            {
                Console.WriteLine("Lap Time {0}: {1:00}:{2:00}:{3:00}.{4:00}", i + 1,
                    lapTimes[i].Hours, lapTimes[i].Minutes, lapTimes[i].Seconds,
                    lapTimes[i].Milliseconds / 10);
            }
        }

        private static void DisplayHeader(bool isRunning)
        {
            Console.WriteLine("Stopwatch Program\nPress Escape to exit\n" + 
                (isRunning ? "(S)top \n" : "(S)tart\n") + 
                "(L)ap Time");
        }
    }
}
