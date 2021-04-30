using System;
using System.Collections.Generic;
using System.Text;
using RealInterfaceAndAbstractClasses.Entities;
using RealInterfaceAndAbstractClasses.Abstract;


namespace RealInterfaceAndAbstractClasses.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
