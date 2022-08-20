using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Çoklu İmplementasyon 
             
             * Bir sınıfa birden fazla arayüz implement edilebilir. 
             * Örnek bir senaryo üzerinden konuyu anlatacak olursak; 
             * Bir fabrika için otomasyon programı yazdığımızı düşünelim. 
             * Fabrikada 3 farklı çalışan türü olsun, bunlar yönetici, işçi ve robot. 
             * Her bir çalışanın ID, ad-soyad, adres, maaş, departman ve toplam çalışma saati bilgisi olsun. 
             */
        }

    }

    /*
    interface ICalisan
    {
        int id { get; set; }
        string adSoyad { get; set; }
        string adres { get; set; }
        double maas { get; set; }
        string departman { get; set; }
        ulong toplamCalismaSaati { get; set; }

        // Eğer arayüz tasarımını yukarıdaki gibi yaparsak ICalisan arayüzünü, oluşturacağımız Yonetici ve Isci sınıflarına implement edebiliriz ancak Robot sınıfına implement edemeyiz.Çünkü robotların adlarının ve adreslerinin olmayacağını ve maaş almayacaklarını biliyoruz.Bu yüzden ICalisan arayüzünü uygun bir şekilde parçalamamız gerekiyor. 
    }
    */

    interface ICalisan
    {
        int id { get; set; }
        string departman { get; set; }
        ulong toplamCalismaSaati { get; set; }
    }

    class Kisi
    {
        string adSoyad { get; set; }
        string adres { get; set; }
        double maas { get; set; }
    }

    class Yonetici : Kisi, ICalisan
    {
        public int id { get; set; }       
        public string departman { get; set; }
        public ulong toplamCalismaSaati { get; set; }
    }
    class Isci : Kisi,ICalisan
    {
        public int id { get; set; }        
        public string departman { get; set; }
        public ulong toplamCalismaSaati { get; set; }
    }

    class Robot : ICalisan
    {
        public int id { get; set; }
        public string departman { get; set; }
        public ulong toplamCalismaSaati { get; set; }
    }
}
