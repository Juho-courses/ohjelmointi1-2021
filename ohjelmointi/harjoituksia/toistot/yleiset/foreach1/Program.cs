using System;

namespace foreach1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = {"mo", "mo2", "mo3"};

            foreach (string sana in sanat) {
                Console.WriteLine(sana);
            }
        }
    }
}
