using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lukuja = {1,2,4,5};
            TulostaArray(lukuja);

            int[] lukuja2 = {3};
            TulostaArray(lukuja2);
        }

        static void TulostaArray(int[] lukuarray) {
            Console.WriteLine("tulostellaan settejä");
            foreach (var item in lukuarray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
