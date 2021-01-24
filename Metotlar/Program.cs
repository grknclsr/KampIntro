using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.UrunAdı = "Elma";
            product1.Fıyat = 15;
            product1.Acıklama = "amasya elması";

            Product product2 = new Product();

            product2.UrunAdı = "Karpuz";
            product2.Fıyat = 20;
            product2.Acıklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAdı);
                Console.WriteLine(product.Fıyat);
                Console.WriteLine(product.Acıklama);
                Console.WriteLine("*********************");
            }

            Console.WriteLine("----------Metotlar------------");


            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(product1);
            basketManager.Ekle(product2);

            

        }
    }
}