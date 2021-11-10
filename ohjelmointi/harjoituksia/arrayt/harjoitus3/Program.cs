using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Anna sana: ");
            // string eka = Console.ReadLine();
            // Console.Write("Anna sana: ");
            // string toka = Console.ReadLine();
            // Console.Write("Anna sana: ");
            // string kolmas = Console.ReadLine();

            // string[] sanat = {eka, toka, kolmas};

            string[] sanat = new string[3];

            Console.Write("Anna sana: ");
            sanat[0] = Console.ReadLine();
            Console.Write("Anna sana: ");
            sanat[1] = Console.ReadLine();
            Console.Write("Anna sana: ");
            sanat[2] = Console.ReadLine();

            Console.WriteLine(sanat[2]);
            Console.WriteLine(sanat[1]);
            Console.WriteLine(sanat[0]);
        }
    }
}
