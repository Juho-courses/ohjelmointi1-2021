using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 43;
            int b = 4;

            if (a == 42 || b == 42)
            {
                Console.WriteLine("42 löytyi!");
            }
            else
            {
                Console.WriteLine("42 ei löytynyt!");
            }
        }
    }
}
