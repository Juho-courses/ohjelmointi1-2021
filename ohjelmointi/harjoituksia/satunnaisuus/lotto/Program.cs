using System;
using System.Linq;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("montako riviä: ");
            // string tmp = Console.ReadLine();
            // int maara = int.Parse(tmp);

            // for (int i = 0; i < maara; i++) {
            //     int[] rivi = LuoRivi();
            //     TulostaRivi(rivi);
            // }

            Console.Write("anna 7 numeroa, pilkuilla eroteltuna: ");
            string[] luvut_str = Console.ReadLine().Split(',');

            int[] rivi = new int[luvut_str.Length];

            for (int i = 0; i < luvut_str.Length; i++) {
                // Console.WriteLine(luvut_str[i]);
                rivi[i] = int.Parse(luvut_str[i]);
            }

            bool isValid = TarkistaRivi(rivi);
            if (isValid) {
                Console.WriteLine("Validi rivi");
            } else {
                Console.WriteLine("huono rivi");
            }
        }

        static void TulostaRivi(int[] rivi) {
            for (int j = 0; j < rivi.Length; j++) {
                Console.Write(rivi[j] + " "); 
            } 
            Console.WriteLine();
        }

        static int[] LuoRivi() {
            int[] rivi = new int[7];

            int lkm = 0;

            Random r = new Random();
            while (lkm < 7) {
                int luku = r.Next(1, 40);

                if (!rivi.Contains(luku)) {
                    rivi[lkm] = luku;
                    lkm++;
                } 
            }

            return rivi;
        }

        static bool TarkistaRivi(int[] rivi) {
            // pituus tasan 7
            if (rivi.Length != 7) {
                return false;
            }
            // luvut 1-40
            foreach (var luku in rivi)
            {
                if (luku < 1 || luku > 40) {
                    return false;
                }
            }
            // uniikit luvut
            Array.Sort(rivi);
            for (int i = 0; i < rivi.Length - 1; i++) {
                if (rivi[i] == rivi[i + 1]) {
                    return false;
                }
            }
            return true;
        }
    }
}
