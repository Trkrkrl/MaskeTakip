using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService//ilerde bu eczane olur veya ptt olur  dağıtıcıdeğişebileceğinden interface ayarladık
    {
        private IApplicantService _applicantService;//newlemek yeri,ne bu özel yapıyı kullanıcaz
        public PttManager(IApplicantService applicantService)//ctor -constructor -new yapıldığında çalışır-pttmanageri bir yerde new yaptıklarında çalışacak
        // ve ben Iapplicantservice e bağlıyım- beni olulturunca bir aday servisi ver
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {//person managere ve icerisndeki checke ihtiyacımız var
            ///PersonManager personManager = new PersonManager();//bu newleme olayı kısıtlayıcı oluyor, vatandaş değilse alamaz yaani mesela
           
            if (_applicantService.CheckPerson(person))//burada bool var fakat defaultu  true person managerde-sonradan aplicant serviceyi baqladık
            {
                Console.WriteLine(person.FirstName+"için maske verildi.");

            }else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi.");

            }


        }

    }



}
