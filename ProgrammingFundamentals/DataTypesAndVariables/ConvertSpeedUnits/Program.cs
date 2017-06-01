using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float miles = distance / 1.0f / 1609;

            float metersPerSecond = (float)distance / (seconds + minutes * 60 + hours * 3600);
            float kilometersPerHour = (float)(distance / 1000.0 / (hours + minutes / 60.0 + seconds / 3600.0));
            float milesPerHour = (float)(miles / (hours + minutes / 60.0 + seconds / 3600.0));

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
