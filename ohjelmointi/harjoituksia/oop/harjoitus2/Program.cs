using System;

namespace harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address osote1 = new Address("satakunnankatu", 23);
            osote1.Print();

            osote1.ChangeAddress("valtakatu", 13);
            osote1.Print();

            Address osote2 = new Address("sakintie", 1);
            osote2.Print();
        }
    }
}
