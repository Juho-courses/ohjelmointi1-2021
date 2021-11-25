using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luo funktio, jolla on argumentti nimeltä ’n’. 
            // Funktio palauttaa arrayn jossa on numerot 0-n.
            int[] arr = LuoArray(100);

            foreach(int luku in arr) {
                Console.WriteLine(luku);
            }
        }

        static int[] LuoArray(int n) {
            int[] lukuja = new int[n + 1];

            for (int i = 0; i < lukuja.Length; i++) {
                lukuja[i] = i;
            }

            return lukuja;
        }
    }
}
