using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = { "1", "2", "3", "4", "5", "asd" };

            // i = i + 1
            for (int i = 0; i < sanat.Length; i++)
            {
                Console.WriteLine(sanat[i]);
            }
        }
    }
}
