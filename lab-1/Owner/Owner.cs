using System;
using System.Linq;
using System.Collections.Generic;
using ProductNamespace;
using IdGeneratorNamespace;

namespace OwnerNamespace
{
    class Owner
    {
        public int Id { get; private set; }

        public string Name{ get; set; }

        public int NumberOfProducts { get; private set; }

        private List<Product> list = new List<Product>(); //в качестве одного из полей продавец имеет список товаров, которыми он владеет

        public Owner(string name)
        {
            Name = name;
            Id = IdGenerator.Generate(IdTypes.OWNER);
        }

        public override string  ToString()
        {
            return "Owner Id: " + Id.ToString() +
            "\nName: " + Name + 
            "\nNumber Of Products: " + NumberOfProducts.ToString();
        }

        public void AddProduct(Product product)
        {
            list.Add(product);
            NumberOfProducts++;
        }

        public bool FindProduct(Product product)
        {
            return ( list.Where(prod => prod.Id == product.Id).Count() > 0 );
        }

        public Product GetProduct(int index)
        {
            return list[index];
        }

        public void RemoveProduct(Product product)
        {
            if( FindProduct(product) )
            {
                list.Remove(product);
                NumberOfProducts--;
            }
        }
    }
}
