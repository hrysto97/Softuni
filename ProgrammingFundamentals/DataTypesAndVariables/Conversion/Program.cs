﻿using System;

namespace Conversion
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hex, 16));
        }
    }
}
