using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager:ISupplierService //sistem bu şekilde çıplak bırakmak inheritance veya implementasyon zaafiyeti ısupplierı ekliyorum o yüzden 
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService)//constructor new yapıldığında çalışır 
        {
            _applicantService = applicantService;//classlarda feildlerin alt çizgi ile başlamasının sebbebi constructorlarda onları set ederiz 

        }

        public void GiveMask(person person)
        {

            //maskeyi vermek için personmanagerdeki bir operasyonu çağırmak gerekiyor 
            //bir maskeyi vermek için adamı kontrol etmek gerekli 
            // PersonManager personManager = new PersonManager(); bu kodda newlediğimiz için bağımlıdır 
            //bunun yerine bir tasarım deseni kullanılır dependency incection ptt managerin bağımlı olduğu sınınf yerine o sınıfların interfaceini yazıyoruz o kısmı classın altına yazıyorum 

            PttManager pttManager = new PttManager(new ForeginerManager());//interfaceler newlenemez ama interfaceler referans tutucudurlar   
            if (/*personManager*/_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");

           }//bu yazılımda değişiklik talebi geldiğinde bu uyguulama direnç gösterir artık newlediğimiz için personmanager a bağlıyız 
            else
            {
                Console.WriteLine(person.FirstName + "için maske VERİLEMEDİ");

            }

        }

       
    }
}
