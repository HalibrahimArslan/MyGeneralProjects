using System;
using System.Collections.Generic;
using System.Text;

namespace Hw2
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müsteri eklendi"+"------->"+customer.CustomerName+" "+customer.CustomerLastName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müsteri : "+customer.CustomerName+" "+customer.CustomerLastName+"Bilgileri Güncellendi");
        }
        public void Display(params Customer[] customers)
        {

            foreach (var item in customers)
            {
                Console.WriteLine("Customers List:" + item.CustomerName + " " + item.CustomerLastName + Environment.NewLine);
            }
            

            
        }
    }
}
