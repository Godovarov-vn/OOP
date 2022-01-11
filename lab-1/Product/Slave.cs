using System;

namespace ProductNamespace
{
    class Slave : Product
    {
        public string LastName { get; set; }

        public int Age{ get; set; }
        public SlavesTypes SlaveType;

        public Slave(string name, int priceInRubles) : base(name, priceInRubles)
        {
            LastName = null;
            Age = -1;
            SlaveType = SlavesTypes.NAN;
        }

        public override string AllToString()
        {
            return BasicToString() + 
            "\nLast Name: " + LastName +
            "\nAge: " + Age.ToString() +
            "\nSlaveType: " + Enum.GetName(typeof(SlavesTypes), SlaveType);
        }
    }
}