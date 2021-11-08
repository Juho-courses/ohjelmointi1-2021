using System;

namespace harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä tekstiä: ");
            string vastaus = Console.ReadLine();
            int pituus = vastaus.Length;
            Console.WriteLine("Kiva juttu! Kirjoitit " + pituus + " merkkiä pitkän tekstin!");
        }
    }
}
