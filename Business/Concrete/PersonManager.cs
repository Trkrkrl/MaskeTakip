using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService // bu bir iş sınıfı , içers,nde bir operasyon yaptırıyoz
    {
        public void ApplyForMask(Person person)//burada string firstname vs de yazabilirdik, ama direkt Person kullanmak daha akıllıca, presom çok yerde de kullanılıyor
        {//yani person sayesinde encapsulation yapılmış oldu içççeriisnde bi dünya özellik barındırıyorr

        }
        //şu ana  kadar kimler maske başvurusunda bulunmuş
        public List<Person> GetList()
        {
            return null;    
        }
        public bool CheckPerson(Person person)//bunu ptt kontroledecek-mernise bağlanacak
        {


            //mernis kontrolü yapılacak
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                person.NationalIdentity, person.FirstName, person.LastName,person.DateOfBirthYear)
                .Result.Body.TCKimlikNoDogrulaResult;
                   
            

        }

    }
}
