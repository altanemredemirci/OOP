using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Okul öğrenci bilgi sistemi 
            // Öğrenci: ad,soyad,numara,bölüm,sinif(9,10,11,12)
            // kayit(),giris(),listeleme():bütün öğrencileri listelesin, find(): bölüme göre listelesin, filter(): sinifa göre listelesin

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            while (true)
            {
                Console.WriteLine("1-Kayıt\n2-Giriş\n3-Listeleme\n4-Bölüme Göre Listeleme\n5-Sınıfa Göre Listeleme\n6-Çıkış\n\tSeçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    ogrenciler.Add(Ogrenci.Kayit());
                    //ogrenciler.Add(Ogrenci.Kayit(ogrenciler));
                }
                else if (secim == 2)
                {
                    if(Ogrenci.Giris(ogrenciler))
                        Console.WriteLine("Giriş Başarılı");
                    else
                        Console.WriteLine("Giriş Başarısız");
                }
                else if (secim == 3)
                {
                    Ogrenci.Listele(ogrenciler);
                }
                else if (secim == 4)
                {
                    Ogrenci.BolumListe(ogrenciler);
                }
                else if (secim == 5)
                {
                    Ogrenci.SinifListe(ogrenciler);
                }
                else if (secim == 6)
                {
                    break;
                }
            }
        }
    }
    class Ogrenci
    {
        //sınıfın propertyleri
        public string Ad;
        public string Soyad;
        public int Numara;
        public string Bolum;
        public int Sinif;

        public static Ogrenci Kayit()
        {
            Ogrenci ogrenci = new Ogrenci(); // instance(Örneklem) ogrenci:nesne
            Console.WriteLine("Ad:");
            ogrenci.Ad = Console.ReadLine();

            Console.WriteLine("Soyad:");
            ogrenci.Soyad = Console.ReadLine();

            Console.WriteLine("Numara:");
            ogrenci.Numara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bölüm:");
            ogrenci.Bolum = Console.ReadLine();

            Console.WriteLine("Sınıf:");
            ogrenci.Sinif = Convert.ToInt32(Console.ReadLine());

            return ogrenci;
        }
        public static bool Giris(List<Ogrenci> liste)
        {
            Console.WriteLine("Numara:");
            int no = Convert.ToInt32(Console.ReadLine());

            bool GirisDurumu = false;
            foreach (Ogrenci item in liste)
            {
                if (item.Numara == no)
                {
                    GirisDurumu = true;

                }
            }

            return GirisDurumu;
        }

        public static void Listele(List<Ogrenci> liste)
        {
            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Ad+" "+item.Soyad+" " + item.Bolum+" " + item.Numara + " " + item.Sinif);
            }
        }

        public static void BolumListe(List<Ogrenci> liste)
        {
            Console.WriteLine("Bölüm:");
            string Bolum = Console.ReadLine();

            foreach (Ogrenci item in liste)
            {
                if (item.Bolum == Bolum)
                {
                    Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Bolum + " " + item.Numara + " " + item.Sinif);
                }
                
            }
        }

        public static void SinifListe(List<Ogrenci> liste)
        {
            Console.WriteLine("Sinif:");
            int Sinif = Convert.ToInt32(Console.ReadLine());

            foreach (Ogrenci item in liste)
            {
                if (item.Sinif == Sinif)
                {
                    Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Bolum + " " + item.Numara + " " + item.Sinif);
                }

            }
        }
    }
}
