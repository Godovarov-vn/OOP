using System;
using ProductNamespace;
using OwnerNamespace;

class Program
{
    static void PrintAllInformation(Owner owner)
    {
        Console.WriteLine("----------Owner Info---------");
        Console.WriteLine(owner.ToString());
        Console.Write('\n');
        Console.WriteLine("----------Products Info------");
        for(int i = 0; i < owner.NumberOfProducts; i++)
        {
            Console.WriteLine( owner.GetProduct(i).AllToString() );
            Console.Write('\n');
        }
        Console.Write("\n\n");
    }

    static void Main()
    {
        Car car1 = new Car("car 1", 1001) {CompanyName = "company 1", ModelName = "model 1", MaxSpeed = 100, NumberOfSeats = 1, };
        Car car2 = new Car("car 2", 2001) {CompanyName = "company 2", ModelName = "model 2", MaxSpeed = 200, NumberOfSeats = 2, };
        Car car3 = new Car("car 3", 3001) {CompanyName = "company 3", ModelName = "model 3", MaxSpeed = 300, NumberOfSeats = 3, };

        Book book1 = new Book("Book 1", 1002) {Author = "author 1", NumberOfPages = 100};
        Book book2 = new Book("Book 2", 2002) {Author = "author 2", NumberOfPages = 200};
        Book book3 = new Book("Book 3", 3002) {Author = "author 3", NumberOfPages = 300};

        Slave slave1 = new Slave("Slave 1", 1003) { LastName = "lastname 1", Age = 10, SlaveType = SlavesTypes.MAN };
        Slave slave2 = new Slave("Slave 2", 2003) { LastName = "lastname 2", Age = 20, SlaveType = SlavesTypes.WOMAN };
        Slave slave3 = new Slave("Slave 3", 3003) { LastName = "lastname 3", Age = 30, SlaveType = SlavesTypes.MAN };

        Owner owner1 = new Owner("owner 1");
        Owner owner2 = new Owner("owner 2");
        Owner owner3 = new Owner("owner 3");

        owner1.AddProduct(car1);
        owner1.AddProduct(book1);
        owner1.AddProduct(slave1);

        owner2.AddProduct(car2);
        owner2.AddProduct(book2);
        owner2.AddProduct(slave2);

        owner3.AddProduct(car3);
        owner3.AddProduct(book3);
        owner3.AddProduct(slave3);

        PrintAllInformation(owner1);
        PrintAllInformation(owner2);
        PrintAllInformation(owner3);
    }
}