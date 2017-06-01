﻿using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            long days = (long)Math.Floor(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years" +
                $" = {days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} milliseconds = " +
                $"{microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
