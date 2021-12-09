using System;


namespace puhelin
{
    class Phone {
        public string Model {private set; get;}
        public bool CallOngoing {private set; get;} = false;
        public string Number {private set; get;}

        public Phone(string _model) {
            Model = _model;
        }

        public void Call(string _number) {
            if (CallOngoing == true) {
                Console.WriteLine($"Call already ongoing with {Number}");
                return;
            }
            Number = _number;
            CallOngoing = true;
            Console.WriteLine($"Calling number {Number}");
        }

        public void EndCall() {
            if (CallOngoing) {
                CallOngoing = false;
                Console.WriteLine("Hanging up");
            } else {
                Console.WriteLine("no call to hang up");
            }
        }
    }
}