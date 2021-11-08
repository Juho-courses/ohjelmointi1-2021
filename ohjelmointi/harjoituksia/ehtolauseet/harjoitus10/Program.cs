using System;

namespace harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku: ");
            string eka = Console.ReadLine();
            Console.Write("Anna toinen luku: ");
            string toka = Console.ReadLine();

            Console.WriteLine(eka + toka);

            int ekaluku = Int16.Parse(eka);
            int tokaluku = Int16.Parse(toka);

            Console.WriteLine(ekaluku + tokaluku);
            
        }
    }
}
