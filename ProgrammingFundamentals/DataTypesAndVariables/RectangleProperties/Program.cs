using System;

namespace RectangleProperties
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = a * 2 + b * 2;
            double area = a * b;
            double diagonal = Math.Sqrt(a*a + b*b);

            Console.WriteLine(Math.Round(p, 1));
            Console.WriteLine(Math.Round(area, 2));
            Console.WriteLine(diagonal);

        }
    }
}
