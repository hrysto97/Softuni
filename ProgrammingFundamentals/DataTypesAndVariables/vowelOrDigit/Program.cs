using System;


namespace vowelOrDigit
{
    class Program
    {
        static void Main()
        {
            char chr = char.Parse(Console.ReadLine());

            if (Char.IsDigit(chr))
            {
                Console.WriteLine("digit");
                return;
            }

            switch (chr)
            {
                case 'a':
                case 'e':
                case 'o':
                case 'u':
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
            
        }
    }
}
