using System;

namespace harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako lukua annat: ");
            string tmp = Console.ReadLine();
            int vastaus = int.Parse(tmp);

            int maara = 0;
            string sana = "";
            int pituus = 0;
            while (maara < vastaus) {
                Console.Write("sana: ");
                sana = Console.ReadLine();

                if (sana == "") {
                    continue;
                }

                pituus += sana.Length;
                maara++;
            }
            Console.WriteLine("yhteenlaskettu pituus: " + pituus);
        }
    }
}
