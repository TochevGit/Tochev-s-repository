using System;

namespace SecondsConverter
{
    internal class Program
    {
        static int GetTotalSeconds()
        {
            string inValue;

            Console.Write("Enter the total seconds: ");
            inValue = Console.ReadLine();
            return int.Parse(inValue);
        }

        static int CalculateHours(int totalSeconds)
        {
            return totalSeconds / 3600;
        }

        static int CalculateMinutes(int totalSeconds)
        {
            return totalSeconds % 3600 / 60;
        }

        static int CalculateSeconds(int totalSeconds)
        {
            return totalSeconds % 60;
        }

        static void DisplayResults(int totalSeconds, int hours,
            int minutes, int seconds)
        {
            Console.Clear();
            Console.WriteLine("Summary of Time Conversion\n");
            Console.WriteLine("{0, -15} {1,8}", "Total seconds", totalSeconds);
            Console.WriteLine("{0, -15} {1,8}", "Hours", hours);
            Console.WriteLine("{0, -15} {1,8}", "Minutes", minutes);
            Console.WriteLine("{0, -15} {1,8}", "Seconds", seconds);
        }

        static void Main(string[] args)
        {
            int totalSeconds, hours, minutes, seconds;

            totalSeconds = GetTotalSeconds();

            hours = CalculateHours(totalSeconds);
            minutes = CalculateMinutes(totalSeconds);
            seconds = CalculateSeconds(totalSeconds);

            DisplayResults(totalSeconds, hours, minutes, seconds);

            Console.ReadKey();
        }
    }
}
