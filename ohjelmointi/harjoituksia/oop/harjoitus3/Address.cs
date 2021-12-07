using System;


namespace harjoitus3
{
    class Address
    {
        public string Street {private set; get;}     
        public int Number {private set; get;}
        
        public Address(string street, int number) {
            Street = street;
            Number = number;
        }

        public void ChangeAddress(string st, int n) {
            Street = st;
            Number = n;
        }

        public void Print() {
            Console.WriteLine($"{Street}, {Number}");
        }
    }
}