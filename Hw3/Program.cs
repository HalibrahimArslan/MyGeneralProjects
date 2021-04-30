using System;

namespace Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.CustomerName = "Halil";
            customer.CustomerLastname = "Arslan";
            customer.CustomerBirthDate = "03.10.1998";
            customer.CustomerTcNumber = "58867544052";
            LoginManager loginManager = new LoginManager();
            loginManager.LoginSituation(customer);
            IControlManager customerManager = new CustomerControlManager();
            customerManager.Delete();
            customerManager.SignUp();
            customerManager.Update();
        }
    }
}
