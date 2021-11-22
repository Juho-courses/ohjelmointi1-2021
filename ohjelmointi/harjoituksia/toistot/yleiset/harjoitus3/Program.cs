using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int luku = 0; luku <= 20; luku++) {
                if (luku % 3 != 0) {
                    Console.WriteLine(luku);
                }
            }
        }
    }
}
