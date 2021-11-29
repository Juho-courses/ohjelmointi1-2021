using System;

namespace harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            TulostaKertotaulut(8);
            TulostaKertotaulut(8);
            TulostaKertotaulut(8);
            TulostaKertotaulut(8);
        }

        static void TulostaKertotaulut(int max) {
            for (int i = 1; i <= max; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}
