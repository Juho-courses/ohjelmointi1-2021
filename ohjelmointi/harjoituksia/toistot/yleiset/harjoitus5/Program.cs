using System;

namespace harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[10];
            for (int i = 1; i <= luvut.Length; i++) {
                luvut[i - 1] = i;
            }

            // 1 per rivi
            // foreach (int luku in luvut) {
            //     Console.WriteLine(luku);
            // }

            // 2 per rivi
            for (int i = 0; i < luvut.Length; i += 2) {
                int eka = luvut[i];
                int toka = luvut[i + 1];
                Console.WriteLine(eka + " " + toka);
            }
        }
    }
}
