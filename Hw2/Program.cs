using System;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Tunahan";
            customer1.CustomerLastName = "Karabulut";
            customer1.CustomerPhoneNumber = "05316489756";
            Customer customer2 = new Customer();
            customer2.CustomerName = "Mehmet";
            customer2.CustomerLastName = "Kuru";
            customer2.CustomerPhoneNumber = "054689732626";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer2);
            customerManager.Display(customer1, customer2);
        }
    }
}
