using System;

namespace Hw1
{
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductPrize { get; set; }
        public int ProductSaleAmount { get; set; }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1; ;
            product1.ProductName = "Hp G-143";
            product1.ProductPrize = 1400;
            product1.ProductSaleAmount = 100;
            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Apple MacBook";
            product2.ProductPrize = 2000;
            product2.ProductSaleAmount = 1399;

            Product[] urunler = new Product[] { product1, product2 };
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.ProductName);
            }
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ProductName);

            }
            int sayac = 0;
            while (sayac < urunler.Length)
            {
                Console.WriteLine(urunler[sayac].ProductName);
                sayac++;
            }
        }
    }
}
