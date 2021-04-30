using System;
using RealInterfaceAndAbstractClasses.Abstract;
using RealInterfaceAndAbstractClasses.Concrete;
using RealInterfaceAndAbstractClasses.Entities;

namespace RealInterfaceAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Halil İbrahim", LastName = "Arslan", DateOfBirth = new DateTime(1996, 10, 6), NationalityId = "58867544062" };
            BaseCustomerManager baseCustomerManager=new StarbucksCustomerManager(new MernisServiceAdapter.MernisAdapterService());
            baseCustomerManager.Save(customer);

        }
    }
}
