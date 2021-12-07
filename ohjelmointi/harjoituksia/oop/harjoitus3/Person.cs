namespace harjoitus3
{
    class Person {
        public string FirstName {private set; get;}
        public int Age {private set; get;}

        public Address Address {private set; get;}
        public Person(string fname, int age) {
            FirstName = fname;
            Age = age;
        }

        public int MakeOlder() {
            Age += 1;
            return Age;
        }

        public void SetAddress(Address a) {
            Address = a;
        }
    }
}