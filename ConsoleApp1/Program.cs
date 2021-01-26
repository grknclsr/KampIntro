using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 01;
            customer1.Name = "Gürkan";
            customer1.LastName = "Çalışır";
            customer1.TcNo = "1234567890";
            customer1.CustomerNumber = "123456";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 02;
            customer2.CustomerNumber = "0987654321";
            customer2.VergiNo = "654321";
            customer2.CompanyName = "Kodlama.io";

        }
    }
}
