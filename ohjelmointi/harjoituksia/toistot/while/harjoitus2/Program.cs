using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] luvut = { 3.0f, 3.1f, 3.2f };

            float summa = 0f;
            int i = 0;
            while (true)
            {
                summa += luvut[i];
                i++;
                if (i == luvut.Length)
                {
                    break;
                }
            }

            Console.WriteLine("summa " + summa);
        }
    }
}
