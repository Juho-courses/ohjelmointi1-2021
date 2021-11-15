using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] luvut = { 3.0f, 3.1f, 3.2f };

            float summa = 0f;
            for (int i = 0; i < luvut.Length; i++)
            {
                float luku = luvut[i];
                summa = summa + luku;
            }
            Console.WriteLine("summa: " + summa);
        }
    }
}
