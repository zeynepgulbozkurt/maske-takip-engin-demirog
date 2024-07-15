using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Çıplak class kalmasın yani personmanageri kullanmak istersen concreteye gidip class açıp orda pttmanager sınıfı yazarız  
    //bu katman kullanıcıya maske verdiğim bir ortam sunuyor olacak 
    public class PersonManager : IApplicantService
    {
        //başvuracak kişi person olduğu için parametre olarak person yazıyoruz 
        //bu kısım fonksiyon veya method olarak adlandırılır 

        public void ApplyForMask(person person)
            //encapsulation 
        //şuna dikkat etmeliyiz ApplyForMask(string firstName,string lastname, int yil ) şeklinde de yazılabilir ama kullanılması doğru değildir 

        {//nedir bu fonksiyon yapısı? maske başvurusunda diye bir operasyon var biz bunu birçok yerde sıklıkla kullanacağımız bu şeyleri fonksiyonların içerisine yazıyoruz
            
          


        }

        //şu na kadar kimler maske başvurusunda bulunmuş? bi tane daha fonksiyon yazıyoruz 
        public List<person>/* bir listedir bize önceden kimler kullanmış bunu getirecek*/ GetList()

        {
            return null;
        }
        public bool CheckPerson(person person)
        {
            //mernis kontrolü yapılacak
            KPSPublicSoapClient client=new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad:person.FirstName, Soyad:person.LastName, DogumYili:person.DateOfBirhYear))).Result.Body.TCKimlikNoDogrulaResult;

                
            //burda vatandaşın doğruluğunu kontrol ediyor 

        }
    }
}
