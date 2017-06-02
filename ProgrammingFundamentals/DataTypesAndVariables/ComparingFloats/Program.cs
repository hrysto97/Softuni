using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            
            if (a < b)
            {
                double num = a;
                a = b;
                b = num;
            }

            bool isEqual = false;
            if (a - b > 0.000001)
            {
                isEqual = false;
            }
            else
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);
        }
    }
}
