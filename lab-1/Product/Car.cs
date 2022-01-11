using System;

namespace ProductNamespace
{
    class Car : Product
    {
        public string CompanyName { get; set; }
        public string ModelName { get; set; }

        public int MaxSpeed { get; set; }
        public int NumberOfSeats { get; set; }

        public Car(string name, int priceInRubles) : base(name, priceInRubles)
        {
            CompanyName = null;
            ModelName = null;
            MaxSpeed = -1;
            NumberOfSeats = -1;
        }

        public override string AllToString()
        {
            return BasicToString() + 
            "\nCompany Name: " + CompanyName + 
            "\nModelName: " + ModelName + 
            "\nMax Speed: " + MaxSpeed.ToString() +
            "\nNumber Of Seats: " + NumberOfSeats.ToString();
        }
    }
}