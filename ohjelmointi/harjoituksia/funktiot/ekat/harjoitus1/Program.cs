using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
           TulostaEtunimi("Juho"); 
           TulostaEtunimi("Tuomas"); 
           TulostaEtunimi("Manu"); 
        }

        static void TulostaEtunimi(string etunimi) {
            Console.WriteLine("Moi, " + etunimi.Substring(0,4));
        }
    }
}
