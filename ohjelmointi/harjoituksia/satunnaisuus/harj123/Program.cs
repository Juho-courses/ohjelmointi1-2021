using System;

namespace harj123
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eka();
            // Toka();
            Kolmas();
        }
        
        static void Eka() {
            Random r = new Random();
            Console.WriteLine(r.Next(0, 100));
        }

        static void Toka () {
            Console.Write("luku 1: ");
            string vastaus = Console.ReadLine();
            int luku1 = int.Parse(vastaus);
            Console.Write("luku 2: ");
            vastaus = Console.ReadLine();
            int luku2 = int.Parse(vastaus);

            if (luku1 > 0 && luku2 > 0) {
                Random r = new Random();
                int rnd = r.Next(luku1, luku2);
                Console.WriteLine(rnd);
            }
        }

        static void Kolmas() {
            Console.Write("luku 1: ");
            string vastaus = Console.ReadLine();
            int luku1 = int.Parse(vastaus);

            Random r = new Random();
            for (int i = 0; i < luku1; i++) {
                Console.WriteLine(r.Next(1, 50));
            }
        }
    }
}
