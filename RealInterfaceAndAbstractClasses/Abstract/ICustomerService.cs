using System;
using System.Collections.Generic;
using System.Text;
using RealInterfaceAndAbstractClasses.Entities;


namespace RealInterfaceAndAbstractClasses.Abstract
{
    public interface ICustomerService
    {
        public void Save(Customer customer);
    }
}
