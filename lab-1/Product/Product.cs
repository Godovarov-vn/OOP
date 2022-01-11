using System;
using IdGeneratorNamespace;

namespace ProductNamespace
{
    abstract class Product
    {
        public int Id { get; private set; }


        public string Name { get; set; }
        public int PriceInRubles { get; set; }

        public Product(string name, int priceInRubles)
        {
            Name = name;
            PriceInRubles = priceInRubles;
            Id = IdGenerator.Generate( IdTypes.PRODUCT );
        }

    
        public abstract string AllToString();

        public string BasicToString()
        {
            return "Product Id: " + Id.ToString() +
            "\nName: " + Name.ToString() + 
            "\nPrice: " + PriceInRubles.ToString() + " Rubles";
        }
    }
}