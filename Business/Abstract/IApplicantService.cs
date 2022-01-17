using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {//interface içerisinde method imzası barındırabilrisin
        //person managerdeki koldarı kopyaladık buraya ama sadece
        //method imzası kalacak şekkilde temizledik
        //sadece ,mza saklamak için değil
        //yazılımda bağımlılığı çözmek üzerine
        //--  yani üst katman  gibi birşey bu interface
        //foreign veya vatandaş sınıfnın üst katmanı olarak başvuran interface
        //başvuranlara ait methodlar var, mesela foreignde sadece interface çağırdık metotları geldi

        public void ApplyForMask(Person person);
        

        

        public List<Person> GetList();



        public bool CheckPerson(Person person);
        
            
        


    }
}
