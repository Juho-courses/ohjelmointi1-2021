using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Vaihe
            int eka = 10;

            // 2.
            int toka = eka;

            // 3.
            Console.WriteLine(eka);
            Console.WriteLine(toka);

            // 4.
            eka = 234;

            // 5.
            Console.WriteLine(eka);
            Console.WriteLine(toka);

            // Eivät liity tehtävään
            // Console.WriteLine(eka + " " + toka);
            // Console.WriteLine("{0} {1}", eka, toka);
            // Console.WriteLine($"{eka} {toka}");
        }
    }
}
