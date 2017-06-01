using System;

namespace Conversion
{
    class Program
    {
        static void Main()
        {
            string boo = Console.ReadLine();

            if (Convert.ToBoolean(boo))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
