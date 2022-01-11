using System;

namespace ProductNamespace
{
    class Book : Product
    {
        public string Author { get; set; }

        public int NumberOfPages { get; set; }

        public Book(string name, int priceInRubles) : base(name, priceInRubles)
        {
            Author = null;
            NumberOfPages = -1;
        }

        public override string AllToString()
        {
            return BasicToString() + 
            "\nAuthor: " + Author +
            "\nNumber Of Pages: " + NumberOfPages.ToString();
        }
    }
}