using System;

namespace harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna 1. sana: ");
            string eka = Console.ReadLine();

            Console.Write("Anna 2. sana: ");
            string toka = Console.ReadLine();

            if ((eka == "koulu" && toka == "ohjelmointi") || (eka == "ohjelmointi" && toka == "koulu") ) {
                Console.WriteLine("Hienot sanat!");
            } else {
                Console.WriteLine("Ei huonot sanat.");
            }
        }
    }
}
