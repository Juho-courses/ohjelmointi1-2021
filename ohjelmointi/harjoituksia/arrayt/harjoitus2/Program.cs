using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] luvut = new float[3];
            luvut[0] = 3.1f;
            luvut[1] = 3.2f;
            luvut[2] = 3.3f;

            float summa = luvut[0] + luvut[1] + luvut[2];
            Console.WriteLine(summa);
        }
    }
}
