using System;

namespace harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KerroLuvut(2,0));
        }

        static int KerroLuvut(int x1, int x2) {
            int tulos = 0;

            // 2 * 3
            // 2 + 2 + 2
            for (int i = 0; i < x1; i++) {
                tulos += x2;
            }

            return tulos;
        }
    }
}
