using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_HW_2
{
    enum Ogretim_Duzeyi : byte
    {
        ilkogretim,
        ortaogretim,
        lise,
        lisans,
    }
    internal class Ogrenci
    {
        public string AdSoyad;
        public int OkulNo;
        public string OkulAdi="Açık Öğretim";
        public Ogretim_Duzeyi Ogretim;


        public Ogrenci(string AdSoyad, int OkulNo, string OkulAdi, Ogretim_Duzeyi Ogretim)
        {
            this.AdSoyad = AdSoyad;
            this.OkulNo = OkulNo;
            this.OkulAdi = OkulAdi;
            this.Ogretim = Ogretim;

        }


        public virtual void NotHesapla()
        {
            Console.WriteLine("Not Bilgisi Eksik!!!");
        }



    }
}
