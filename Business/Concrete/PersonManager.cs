using Business.Abstract;
using Entities.Concrete;
using MemrisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class PersonManager:IApplicantService
    {
        public void AppyforMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //Memris kontrolü yapacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

                return client.;
        }

    }
}
