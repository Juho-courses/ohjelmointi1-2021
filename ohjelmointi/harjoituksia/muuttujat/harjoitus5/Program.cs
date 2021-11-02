using System;

namespace harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
           string etunimi = "Juho"; 
           string sukunimi = "Salli";

           Console.WriteLine(etunimi + " " + sukunimi);
           Console.WriteLine($"{etunimi} {sukunimi}");

        }
    }
}
