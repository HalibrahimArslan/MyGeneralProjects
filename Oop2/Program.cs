using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Costumer costumer = new Costumer();
            //costumer.Id = 1;
            //costumer.Name = "Halil";
            //costumer.TcNumber = "58867544052";
            //costumer.VergiNumber = "1525215152";
            //costumer.CompanyName = "Topcular";
            //costumer.CompanyName = "?";

            //Gerçek MÜŞTERİ-Tüzel MÜŞTERİ
            //SOLID

            IndividualCostumer costumer1 = new IndividualCostumer();
            costumer1.Id = 1;
            costumer1.CustomerNumber = "12345";
            costumer1.Name = "Halil";
            costumer1.LastName = "Arslan";
            costumer1.TcNumber = "2536974656";

            CoorperateCustomer customer2 = new CoorperateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "Topcular";
            customer2.CompanyName = "Altinova";
            customer2.TaxNumber = "2154565745";

            ////////////////////////////

            Costumer costumer3 = new IndividualCostumer();
            Costumer costumer4 = new CoorperateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(costumer3);
        }
    }
}
