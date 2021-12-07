using System;

namespace harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Juho", 35);
            Console.WriteLine(p1.Age);
            Console.WriteLine(p1.FirstName);

            p1.MakeOlder();
            Console.WriteLine(p1.Age);
            
            // Address osoite = new Address("satakunnankatu", 23);
            p1.SetAddress(new Address("satakunnankatu", 23));
            p1.Address.Print();
        }
    }
}
