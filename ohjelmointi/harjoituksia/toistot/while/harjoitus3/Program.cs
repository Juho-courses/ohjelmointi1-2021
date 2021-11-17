using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sanat = new string[3];

            int index = 0;
            while (index < 3)
            {
                Console.Write("anna sana: ");
                sanat[index] = Console.ReadLine();
                index++;
            }

            index = sanat.Length - 1;
            while (index >= 0)
            {
                Console.WriteLine(sanat[index]);
                index--;
            }
        }
    }
}
