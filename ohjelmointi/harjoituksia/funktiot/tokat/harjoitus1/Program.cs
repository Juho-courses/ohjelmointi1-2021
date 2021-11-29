using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testiArray = {16, 32, 4, 5};

            int suurin = PalautaSuurin(testiArray);
            Console.WriteLine(suurin);
        }

        static int PalautaSuurin(int[] testiArray) {
            int suurin = testiArray[0];
            foreach (int luku in testiArray) {
                if (luku > suurin) {
                    suurin = luku;
                }
            }
            return suurin;
        }
    }
}
