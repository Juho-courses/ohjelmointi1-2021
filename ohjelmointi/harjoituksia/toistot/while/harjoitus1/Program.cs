using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = { "mo", "mo1", "mo3" };
            int indeksi = 0;
            while (indeksi < sanat.Length)
            {
                Console.WriteLine(sanat[indeksi]);
                indeksi++;
            }
        }
    }
}
