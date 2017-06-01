using System;


namespace StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            Object combined = hello + " " + world;

            string hl = (string) combined;
            Console.WriteLine(hl);
        }
    }
}
