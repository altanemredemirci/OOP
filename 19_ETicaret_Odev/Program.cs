using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ETicaret_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bu e-ticaret sitemiz, sanal market olsun. Yani hem gıda hem de elektronik ürünleri satabilecek bir portal. Site kullanıcısı, 
             *satın almak istediği ürünü sepete ekler. Siparişi vermeden önce, sepetteki tüm ürünlerin fiyatları toplanır ve ödenmesi gereken miktar belirlenir.  
             * bu ürünlerin KDV oranları da farklı olacak ve elbette fiyat ona göre hesaplanacak.*/
            
            Sepet s = new Sepet();
            
            Ekmek e = new Ekmek("IHE", "çavdar", 10, 100);
            s.Ekle(e);

            Tekstil t = new Tekstil("Etek", 300.50, "Pamuk", 36, "Koton");
            s.Ekle(t);

            Console.WriteLine(s.ToplamTutar().ToString()); // 10.8 çıkıyor//override etmeden

            s.Yaz();
            
            Console.ReadKey();

            /*Urun sınıfındaki KDVUygula metodu varsayılan olarak %8 vergi uygularsa böyle olur”. Peki tamam. Nasıl çözeceğiz o zaman bu sorunu? KDVUygula metodunu Urun sınıfından kaldırmamalıyız Çünkü tüm ürünlerimde (tekstil,cep telefonu ve ekmek) bu metod var. O zaman şöyle diyebilir miyiz, evet tüm ürünlerde KDVUygula olmalı ama, hepsinde FARKLI çalışmalı!O zaman Urun sınıfında KDVUygulayı virtual yapmalıyız*/
            //Console.WriteLine(s.ToplamTutar().ToString()); 10.8 çıkıyor//override ettikten sonra 10.1 sonucunu aldık ,çok biçimlilik kavramı burada devreye girerek her urunun kdvoranına göre kendi hesaplamasını yaptı

        }
    }

    public class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public virtual void BilgiYaz()
        {
            Console.Write(this.UrunAdi+" "+this.Fiyat+" ");
        }

        public virtual double KDVUygula()
        {
            return Fiyat * 1.08;
            //virtual” anahtar kelimesini ekleyerek metodumun çok biçimli bir metod olduğunu gösterdim. Şimdi de, bu metodun yapısını, türemiş sınıflarımda nasıl değiştireceğime bakalım. Hemen Ekmek sınıfına gidelim ve override kelime sini yazdıktan sonra neler geldiğine bir bakalım:
        }


        public Urun(string ad, double _fiyat)
        {
            UrunAdi = ad;
            Fiyat = _fiyat;
        }
    }

    /*Urun sınıfından Tekstil, CepTelefonu ve kuru gıda ürünlerini temsil edecek sınıflarımı türetiyorum.*/

    public class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }

        public Tekstil(string ad, double fiyat, string kumasturu, int beden,string ureticiFirma) : base(ad, fiyat)
        {
            KumasTuru = kumasturu;
            Beden = beden;
            UreticiFirma = ureticiFirma;
        }

        public override void BilgiYaz()
        {
            base.BilgiYaz();
            Console.Write(this.KumasTuru+" "+this.UreticiFirma+" "+this.Beden);
        }
    }

    public class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }

        public CepTelefonu(string ad, double fiyat, string marka,string ozellikler) : base(ad, fiyat)
        {
            Marka = marka;
            Ozellikler = ozellikler;
        }

        public override void BilgiYaz()
        {
            base.BilgiYaz();
            Console.Write(this.Ozellikler + " " + this.Marka);
        }
    }

    public class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }


        public override void BilgiYaz()
        {
            base.BilgiYaz();
            Console.Write(this.EkmekTuru + " " + this.Gramaj);
        }

        public override double KDVUygula()
        {
            return Fiyat * 1.01;
            //virtual” anahtar kelimesini ekleyerek metodumun çok biçimli bir metod olduğunu gösterdim. Şimdi de, bu metodun yapısını, türemiş sınıflarımda nasıl değiştireceğime bakalım. Hemen Ekmek sınıfına gidelim ve override kelime sini yazdıktan sonra neler geldiğine bir bakalım:
        }
        public Ekmek(string ad, string ekmekTuru, double fiyat, int gramaj) : base(ad, fiyat)
        {
            EkmekTuru = ekmekTuru;
            Gramaj = gramaj;
        }
    }

    /*Peki, şimdi de Sepet sınıfımızı yazalım. Bu sınıf, ürünlerimizi taşıyacak ve “ödenmesi gereken tutar” ı bizim için hesaplayacak.*/

    public class Sepet
    {
        private List<Urun> urunler = new List<Urun>();
        public double ToplamTutar()
        {
            double toplamFiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamFiyat += item.KDVUygula();
            }
            return toplamFiyat;
        }

        public void Yaz()
        {
            foreach (Urun item in urunler)
            {
                item.BilgiYaz();
                Console.WriteLine();
            }
        }

        public void Ekle(Urun yeniUrun)
        {
            urunler.Add(yeniUrun);
        }
    }
}

