using System;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            KerroLuvut(2,2);
            KerroLuvut(32,2);
        }

        static void KerroLuvut(int x1, int x2) {
            Console.WriteLine(x1 * x2);
        }
    }
}
