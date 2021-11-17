using System;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arraylla();
            IlmanArrayta();
        }

        static void IlmanArrayta()
        {
            string sana = "";
            string eka = "";
            string vika = "";
            string pisin = "";
            string lyhin = "";
            int maara = 0;

            while (true)
            {
                Console.Write("sana: ");
                sana = Console.ReadLine();

                if (sana == "lopeta")
                {
                    break;
                }

                vika = sana;

                if (eka == "")
                {
                    eka = sana;
                }

                if (sana.Length > pisin.Length)
                {
                    pisin = sana;
                }
                if (sana.Length < lyhin.Length || lyhin == "")
                {
                    lyhin = sana;
                }

                maara++;
            }

            Console.WriteLine("Syötit " + maara + " sanaa");
            Console.WriteLine("Ensimmäinen sana: " + eka);
            Console.WriteLine("Viimeinen sana: " + vika);
            Console.WriteLine("Pisin sana: " + pisin);
            Console.WriteLine("Lyhin sana: " + lyhin);


        }

        static void Arraylla()
        {
            string[] sanat = new string[10];

            int maara = 0;
            while (maara < 10)
            {
                Console.Write("sana: ");
                string sana = Console.ReadLine();

                if (sana == "lopeta")
                {
                    break;
                }

                sanat[maara] = sana;
                maara++;
            } // while loppuu

            Console.WriteLine("Syötit " + maara + " sanaa");
            if (maara > 0)
            {
                Console.WriteLine("eka sana: " + sanat[0]);
                Console.WriteLine("vika sana: " + sanat[maara - 1]);

                string lyhin = sanat[0];
                string pisin = sanat[0];

                for (int i = 0; i < maara; i++)
                {
                    if (sanat[i].Length > pisin.Length)
                    {
                        pisin = sanat[i];
                        continue;
                    }
                    if (sanat[i].Length < lyhin.Length)
                    {
                        lyhin = sanat[i];
                    }
                }
                Console.WriteLine("lyhin: " + lyhin);
                Console.WriteLine("pisin: " + pisin);
            }
        }
    }
}
