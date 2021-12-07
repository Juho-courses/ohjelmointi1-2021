namespace harjoitus1 {
    class Car
    {
        // ominaisuudet
        // valmistaja (str)
        // kilsat (int)
        public string Manufacturer {private set; get; }
        public int DistanceDriven {private set; get;}

        // Konstruktori
        public Car(string _manufacturer) {
            Manufacturer = _manufacturer;
            DistanceDriven = 0;
        }

        // Metodit
        public void Drive(int distance) {
            if (distance < 0) {
                return;
            }
            DistanceDriven += distance;
        }
    }
}