using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            int num = a;
            a = b;
            b = num;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
