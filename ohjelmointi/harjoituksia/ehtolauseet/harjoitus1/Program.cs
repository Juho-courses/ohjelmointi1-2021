using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 35;
            string name = "Oskari";

            if (name == "Juho" && age == 35)
            {
                Console.WriteLine("moi " + name + "!");
            }
            else
            {
                Console.WriteLine("henkilö ei tunnistettu");
            }
        }
    }
}
