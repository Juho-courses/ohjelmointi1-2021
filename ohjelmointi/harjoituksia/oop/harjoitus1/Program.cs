using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car opel = new Car("Opel");
            Console.WriteLine(opel.DistanceDriven);
            Console.WriteLine(opel.Manufacturer);

            opel.Drive(-500);
            Console.WriteLine(opel.DistanceDriven);


            Car skoda = new Car("Skoda");
            skoda.Drive(5);

        }
    }
}
