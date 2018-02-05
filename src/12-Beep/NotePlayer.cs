using System;

namespace _12_Beep
{
    public class NotePlayer
    {
        public void Play(string[] args)
        {
            foreach (var a in args)
            {
                Console.Beep(GetFrequency(a), 500);
            }
        }

        private int GetFrequency(string note)
        {
            // See https://en.wikipedia.org/wiki/Piano_key_frequencies
            // for note frequencies. Here we are treating A as the lowest and not 
            // bothering with octaves. Keep it simple initially.

            switch (note.ToUpper())
            {
                case "A":
                    return 440;
                case "B":
                    return 494;
                case "C":
                    return 523;
                case "D":
                    return 587;
                case "E":
                    return 659;
                case "F":
                    return 698;
                case "G":
                    return 784;
                default:
                    throw new ApplicationException(string.Format("Invalid or unsupported note \"{0}\" specified.", note));
            }
        }
    }
}
