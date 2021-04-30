using System;
using System.Collections.Generic;
using System.Text;
using RealInterfaceAndAbstractClasses.Abstract;
using RealInterfaceAndAbstractClasses.Entities;
using MernisServiceReference;


namespace RealInterfaceAndAbstractClasses.MernisServiceAdapter
{
    public class MernisAdapterService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
