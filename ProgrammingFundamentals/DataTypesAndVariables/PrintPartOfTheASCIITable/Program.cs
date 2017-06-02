using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main()
        {
            char a =(char) int.Parse(Console.ReadLine());
            char b = (char)int.Parse(Console.ReadLine());

            for(char i = a; i <= b; i++)
            {
                
                Console.Write(i + " ");
            }
        }
    }
}
