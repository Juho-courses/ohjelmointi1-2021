using System;

namespace harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anna 1. sana:");
            string eka = Console.ReadLine();

            Console.WriteLine("anna 2. sana:");
            string toka = Console.ReadLine();

            int eka_pituus = eka.Length;
            int toka_pituus = toka.Length;

            if (eka_pituus > toka_pituus) {
                Console.WriteLine(eka);
            } else if (toka_pituus > eka_pituus) {
                Console.WriteLine(toka);
            } else if (eka_pituus == toka_pituus) {
                Console.WriteLine(eka_pituus+toka_pituus);
            }
        }
    }
}
