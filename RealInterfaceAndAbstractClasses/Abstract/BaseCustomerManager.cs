using RealInterfaceAndAbstractClasses.Entities;
using RealInterfaceAndAbstractClasses.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealInterfaceAndAbstractClasses.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to Db" + customer.FirstName);
        }
    }
}
