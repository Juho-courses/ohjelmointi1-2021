using System;

namespace harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = {"mo", "mo12312", "juho", "moi"};
            foreach (string sana in sanat)
            {
                if (sana.Length < 3) {
                    continue;
                }
                Console.WriteLine(sana);
                // if (sana.Length >= 3) {
                //     Console.WriteLine(sana);
                // }
            }
        }
    }
}
