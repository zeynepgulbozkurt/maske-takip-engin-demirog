using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO.Pipes;

namespace Workaround
{
     class Program
    {
        static void Main(string[] args)
        {
          //  Degiskenler();
          //Vatandas vatandas1 = new Vatandas();
            SelamVer(isim:"zeynep");
            SelamVer(isim:"ayşe");
            SelamVer(isim:"ahmet");
            SelamVer();
            int sonuc=Topla(6,58);

            //DİZİLER ARRAYS
            //örn elimizde 10 tane öğrenci var 
            string ogrenci1 = "Zeynep";
            string ogrenci2 = "ali";
            string ogrenci3 = "ayşe";// listeye yeni bir örnek eklemek istesek olmaz çünkü eleman sayısını 3 girdik hata verirr 
          
            

            
          
            /*
            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);    
            Console.WriteLine(ogrenci3); bunu bu şekilde yapmak yerine bir tane string array tanımlarız string array:içerisinde tanımladığımız tipte veri tutan yapılardır */
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "zeynep";
            ogrenciler[1] = "ali";
            ogrenciler[2] = "ayse";//döngüler birbirine  enzer işi tekrar tekrar yazmak yerine 1 kerede yapma sürecidir
                                   // aşağıdaki kodu yazdığımızda sadece ilkeri yazar diğer isimler olmaz bunun sebebini deftere şekilli görsellerle birlikte yazdım
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length /*lenght demek eelemean sayısı demektir*/; i++) //burda bir döngü tanımı var i sayaç demektir bir değişken tanımladık ve onu 0 dan başlattık 

            {
                Console.WriteLine(ogrenciler[i]);
 
            }
            // örneğin aşağıdaki gibi bir array oluşturalım deftere yazdıklarımın pekiştirmesi 
            string[] sehirler1 = new string[] { "Ankara", "Mersin", "Hatay" };
            string[] sehirler2 = new string[] { "İstanbul", "Eskişehir", "İzmir" };
            sehirler2 = sehirler1 ;// bu kısım değer atamak değildir sehirler2 nin referans numarasını sehirler1 i gösteriri yani bize ankara mersin hatay olarak gösterecek 
            sehirler1[0] = "Adana";//burda sehirler1 in 0 ıncı elemanını yani ankarayı adana olarak değiştirdik
            Console.WriteLine(sehirler2[0]);//burda da sehirler 2 yi getir dedi ama referans olarak sehirler1 i gösteriyor burda da sehirler1 i adana yaptık o yüzden çıktı adana olur 


            //int,double,bool gibi tipler değer tipleridir bunlar direkt atanırlar yani referans mantığı burda yok 

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;//sayi2=10 olur 
            sayi1 = 30;//sayi1=30 olur 
            //sayi2=?????


            person person1 = new person();
            person1.FirstName = " Zeynep Gül ";
            person1.LastName = "Bozkurt";
            person1.DateOfBirhYear = 2002;
            person1.NationalIdentity = 1234567;

            person person2 = new person();
            person2.FirstName = " ";

            //string bir referans tiptir char arraydir

            foreach (string sehir in sehirler1)//sehirler1 i dolaş demek ama dolaşırken her dolaştığında  ona bi takma isim veriyor yani dizileri foreach ile de gezebiliyoruz 

            {
                Console.WriteLine(sehir);
            }
            
            // biz yukardaki arrayler yerine generic koleksiyon dedikleri şeyi getirdikten sonra genel olarak aşaıdaki yapı kullanılmaya başlandı 
            List<string>yeniSehirler1 = new List<string> { "ankara1","istanbul1","izmi1r1"};//arka planda benim yerime bu listeyi yöneten bir yapı var 
            yeniSehirler1.Add(item: "Adana1");//burda direkt izmiri ekleyecek 4 elemanın hepsini de hyazdırıyor 
            foreach(string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);

            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            // vatandas1. bu kodu bu şekilde yazdığımda tanımlanmadı çünkü bir class ın içerisinde bğir değişken tanımlarsak o değişkenleri sadece o classın içerisinde kullanılabilir public dersek eğer sadece classta değil dışarıda da kullanılarbilir  
            /* {
           public string ad = "Zeynep";
           public string soyad = "Bozkurt";
           public int dogumYili = 2002;
           public long tcNo;12121212121;
       }
            */
            Console.ReadLine();
        }

      
      



        //bu kısımda örneğin uygulamanaın
        //içerisinde bir mesaj çıkarmak istiyorum bu bir fonksiyon olur brojede bunu istediğim kadar istediğim yerde kullanabilirim 
        static void SelamVer(string isim= "isimsiz" /*buna default parmetre deniyor*/)//bana bir isim vermesini isteyeceğim fonksiyonun isminden sora parantezin içerisine yazan şeylere parametre denir 
        {
            //void metodlar sadece işi yapar ve herhangi bir bilgi vermez emir kipiyle çalışır 

            Console.WriteLine("Merhaba " + isim);
        }
        //bir değer oluşturmak istiyorsan değer return eden fonksiyonlardan yararlanırsın 
       static int Topla(int sayi1=5,int sayi2=1)
        {
            int sonuc = sayi1 + sayi2;// bu değişken bu bloğun içerisinde geçerli, o kırmızı noktaya break point deniyor kırma noktasıdır proje buraya gelince durur 
            Console.WriteLine("Toplam " + sonuc.ToString());
            return sonuc;
            //hesap yap değer ver gibi şeyler isttiyorsan returnden yararlanırsın 
        }
     


       /* private static void Degiskenler()
        {
            //örneğin aşağıda yazdığım kodu yani console.WriteLine("merhaba") kodunu sürekli tekrar etmemi gerektirecek bir durumda kalırsam string değişkenini kullanabiliri//

            string mesaj = "Merhaba";
            //örn bir bankasın sen bir kredi vereceksin bunu double ile gösteririz ondalıklı bir sayı olarak da verilerbilir
            double tutar = 100000.5;// bir db den yani bir veritabanından gelir bu 
            int 100; //tam sayıları burda tutarız
            bool girisYapmisMi = false;// değeri doğru ya da yanlış olabilecek durumlarda kullanılır uygulamayı dallandırmak için çok kullanılır.örn instagramda giris yaptın mı yapmadın mı 


            // bir maske takip sistmi
            //bir sistem düşün kişi var personel var vatandaş var bir sürü değişken tanımlamak gerekecek o yüzden bunu bu şekillde yapmak yerine bun ları mantıksal gruplara ayıracağaız bunlara nesne denir biz bu aşağıda yazdığımızı bir kutuya koysak o kutuya bir isim verilese bunlara nesne yani class denir. 
            string ad = "Zeynep";
            string soyad = "Bozkurt";
            int dogumYili = 2002;
            long tcNo; 12121212121;//11 sayıyı tutacak kadar bir veri tipi



            Console.WriteLine(tutar * 1.18); //bu şekilde de yazılabilir 

            Console.WriteLine(100000.5 * 1.18); //şeklinde de yazılabilir ama anladığım kadarıyla bu uğraştırıcı

            Console.WriteLine(mesaj);

            Console.WriteLine(mesaj);

            Console.WriteLine(mesaj);
        }
    }
    //pascal casing

   public class Vatandas
        //bu şu anlama gelir vatandas.ad dediğimde zeynepe soyad dediğimde bozkurta ulaşacak yani değişkenlerle değil classın kendisiyle uğarşıyor olacağım
    {
        // örneğin zeynep ismini getirdiğimizde otomatik olarak sonuna hanım getirmek istiyoruz kullanıcı zeynep girdiğinde sonnuna hanım gelmesi için şu yapılır 

        /*public string ad = "Zeynep";
        public string soyad = "Bozkurt";
        public int dogumYili = 2002;
        public long tcNo;12121212121;*/
        // get ve set özelliklerini değiştirmek istenirse { ile içerisine eklenecek özellikler yazılabillir ama günümüzde az kullnılan özelliklerden birisidir bu yüzden biz get ve setleri property ile yazıyoruz javada bunları ayrı ayrı get ve set blokları ile yazarız  
        /*public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set;}
        public long TcNo { get; set; }*/
       

    }
}
