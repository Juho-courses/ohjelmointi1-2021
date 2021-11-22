using System;

namespace foreach2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] luvut = {3.0f, 3.1f, 3.2f};
            float summa = 0f;
            foreach (float luku in luvut) {
                summa += luku;
            }
            Console.WriteLine(summa);
        }
    }
}
