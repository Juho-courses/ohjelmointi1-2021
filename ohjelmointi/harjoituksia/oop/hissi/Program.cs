using System;

namespace hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator hissi = new Elevator(5);
            hissi.Start(5);
            // hissi.Print();
            Console.WriteLine(hissi.CurrentFloor);

            hissi.Start(1);
            hissi.Start(4);
        }
    }
}
