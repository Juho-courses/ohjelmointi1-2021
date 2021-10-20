using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ja 2
            float almost_pi;
            almost_pi = 3.12f;

            // 3
            float other_not_pi = 6.0f;

            // 4
            almost_pi = almost_pi - other_not_pi;
            // almost_pi -= other_not_pi;

            // 5
            Console.WriteLine(almost_pi);
            Console.WriteLine(other_not_pi);
        }
    }
}
