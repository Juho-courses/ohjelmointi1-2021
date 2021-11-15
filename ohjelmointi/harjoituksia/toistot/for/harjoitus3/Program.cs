using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maara = 4;
            string[] sanat = new string[maara];

            for (int i = 0; i < sanat.Length; i++)
            {
                Console.Write("Kirjoita sana: ");
                string sana = Console.ReadLine();
                sanat[i] = sana;
            }

            // i = i - 1
            for (int i = sanat.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sanat[i]);
            }

        }
    }
}
