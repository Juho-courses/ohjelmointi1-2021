using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2
            int[] lukuja = {123,3,4,3,5 };
            Console.WriteLine(lukuja[0]);
            Console.WriteLine(lukuja[lukuja.Length - 1]);

            // 3
            int summa = 0;
            foreach (var item in lukuja)
            {
                summa += item;
            }
            Console.WriteLine(summa);
        }
    }
}
