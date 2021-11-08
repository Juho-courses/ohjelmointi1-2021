using System;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 200;

            if (numero < 100) {
                Console.WriteLine("arvo on aika pieni");
            } else if (numero == 100) {
                Console.WriteLine("arvo on sata");
            } else if (numero > 100 && numero <= 200) {
                Console.WriteLine("alkaa olla aika iso luku");
            } else if (numero > 200) {
                Console.WriteLine("nyt ollaan isoissa luvuissa");
            }
        }
    }
}
