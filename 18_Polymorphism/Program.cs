using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Muhendis Muhendis1 = new Muhendis();
            Console.WriteLine("Muhendis Cagrildi");
            Muhendis1.Calis();

            Ogretmen Ogretmen1 = new Ogretmen();
            Console.WriteLine("\nOgretmen Cagirildi");
            Ogretmen1.Calis();

            Mudur Mudur1 = new Mudur();
            Console.WriteLine("\nMudur Cagrildi");

            Mudur1.Calis();

            Console.ReadLine();
        }
    }

    class PersonelBase
    {
        //Temel sınıftaki Calis metodu virtual anahtarı kullanılarak virtual metot olarak tanımlanıyor.
        public virtual void Calis()
        {
            Console.WriteLine("Ben Personel Temel Sınıfının Çalış Metoduyum");
        }

    }
    //PersonelBase sınıfından miras alınarak Muhendis sınıfı bildiriliyor.
    class Muhendis : PersonelBase
    {
        //override anahtarı ile Calis metodu tanımlanıyor. Override anahtarı temel sınıftan gelen Calis metodunun ezileceği anlamını taşıyor.
        public override void Calis()
        {
            Console.WriteLine("Ben Mühendisim Proje Çiziyorum");
        }
    }

    //PersonelBase sınıfından miras alınarak Ogretmen sınıfı bildiriliyor.

    class Ogretmen : PersonelBase
    {
        //override anahtarı ile Calis metodu tanımlanıyor. Override anahtarı temel sınıftan gelen Calis metodunun ezileceği anlamını taşıyor.

        public override void Calis()
        {
            Console.WriteLine("Ben Öğretmenim Ders Anlatırım");
        }
    }

    class Mudur : PersonelBase
    {
        //override anahtarı ile Calis metodu tanımlandıktan sonra metot içerisinde base.Calis(); kullanılarak
        //ana metotdaki calis metodu çağrılıyor. Burada türetilen sınıftaki değil ana sınıftaki metodun çağrılmasının
        //örneğini görüyoruz.

        //public override void Calis()
        //{
        //    base.Calis();
        //}
    }
}