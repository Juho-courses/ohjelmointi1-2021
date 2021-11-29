using System;

namespace harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 3;
            for (int i = 1; i <= max; i++) {
                for (int j = 1; j <= 10; j++) {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}
