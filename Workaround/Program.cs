using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    public class Program  
    {
        static void Main(string[] args)
        {
            Vatandas vatandas = new Vatandas();//bir adet instance oluşturduk  
            SelamVer();
            Person person1 = new Person();
            person1.FirstName = "Türker";
            person1.LastName = "Karaoğlu";
            person1.NationalIdentity =29211111111  ;
            person1.DateOfBirthYear = 1996;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

















            Console.ReadLine();

        }
        static void SelamVer(string isim="NoName")
        {
            Console.WriteLine("Merhaba "+isim);
        }

        
        
    }
    public class Vatandas{//içerisindeki elemanları public ypamassan erişilemez
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
