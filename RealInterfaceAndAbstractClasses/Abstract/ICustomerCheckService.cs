using System;
using System.Collections.Generic;
using System.Text;
using RealInterfaceAndAbstractClasses.Entities;

namespace RealInterfaceAndAbstractClasses.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
