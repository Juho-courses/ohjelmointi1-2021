using System;

namespace harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;

            if (numero % 2 == 0) {
                Console.WriteLine("parillinen");
            } else {
                Console.WriteLine("pariton");
            }
        }
    }
}
