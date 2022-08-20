using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Ogrenci_Odev
{

    enum OgretimDuzeyleri : byte { İlköğretim, Ortaöğretim, Lise, Lisans };

    class Ogrenci
    {
        protected string AdSoyad;
        protected string OkulNumarasi;
        protected string OkulAdi = "Açıktan Eğitim";
        protected OgretimDuzeyleri OgrDuzey;
        ArrayList OgrenciList = new ArrayList();

        public Ogrenci(string adSoyad, string okulNumarasi, string okulAdi, OgretimDuzeyleri ogrDuzey)
        {
            this.AdSoyad = adSoyad;
            this.OkulNumarasi = okulNumarasi;
            this.OkulAdi = okulAdi;
            this.OgrDuzey = ogrDuzey;

            OgrenciList.Add(this.AdSoyad);
            OgrenciList.Add(this.OkulNumarasi);
            OgrenciList.Add(this.OkulAdi);
            OgrenciList.Add(this.OgrDuzey);
        }

        public virtual void NotHesapla()
        {
            Console.WriteLine("Not Bilgisi Eksik!");
        }

    }
    class LiseOgrencisi : Ogrenci
    {
        public LiseOgrencisi(int not1, int not2, string adSoyad, string okulNumarasi, string okulAdi, OgretimDuzeyleri ogrDuzey) : base(adSoyad, okulNumarasi, okulAdi, ogrDuzey)
        {
            this.OkulAdi = okulAdi;
            this.Not1 = not1;
            this.Not2 = not2;
        }

        private new string OkulAdi;

        private int gNot1;
        private int Not1
        {
            get { return gNot1; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    gNot1 = value;
                }
                else
                {
                    Console.WriteLine("Not Aralığını Yanlış Girdiniz ! Notunuz 0 olarak hesaplanacak.");
                    gNot1 = 0;
                }
            }
        }
        private int gNot2;
        private int Not2
        {
            get { return gNot2; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    gNot2 = value;
                }
                else
                {
                    Console.WriteLine("Not Aralığını Yanlış Girdiniz ! Notunuz 0 olarak hesaplanacak.");
                    gNot2 = 0;
                }
            }
        }

        public override void NotHesapla()
        {
            int dersOrtalamasi = (gNot1 + gNot2) / 2;
            Console.Write("Ders ortalaması : " + dersOrtalamasi);

            if (dersOrtalamasi >= 85 && dersOrtalamasi <= 100)
            {
                Console.WriteLine("\t\t Ders Derecelendirmesi : Pekiyi");
            }
            else if (dersOrtalamasi >= 70 && dersOrtalamasi <= 84)
            {
                Console.WriteLine("\t\t Ders Derecelendirmesi : İyi");
            }
            else if (dersOrtalamasi >= 60 && dersOrtalamasi <= 69)
            {
                Console.WriteLine("\t\t Ders Derecelendirmesi : Orta");
            }
            else if (dersOrtalamasi >= 50 && dersOrtalamasi <= 59)
            {
                Console.WriteLine("\t\t Ders Derecelendirmesi : Geçer");
            }
            else if (dersOrtalamasi >= 0 && dersOrtalamasi <= 49)
            {
                Console.WriteLine("\t\t Ders Derecelendirmesi : Tekrar");
            }
            else
            {
                Console.WriteLine("Not Hesaplamada Bir Hata Var !!!");
            }
        }
    }

    class Program
    {
        static void OgrenciNotHesapla(Ogrenci ogr)
        {
            ogr.NotHesapla();
        }
        static void Main(string[] args)
        {
            LiseOgrencisi logr = new LiseOgrencisi(50, 70, "Mehmet DEMİR", "432", "YİBO", OgretimDuzeyleri.Lise);            

            OgrenciNotHesapla(logr);

            Console.ReadKey();

        }
    }
}

