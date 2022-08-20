using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_HW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> OgrenciListesi = new List<Ogrenci>();

            //Ogrenci o = new Ogrenci("Emre Koçak", 1401006, "YTU", Ogretim_Duzeyi.lisans);
            //OgrenciListesi.Add(o);


            Lise m = new Lise("Ali Veli", 123, "Fen Lisesi", Ogretim_Duzeyi.lise, 70, 90);

            Lisans a = new Lisans("Ahmet Mehmet", 456, "ODTÜ", Ogretim_Duzeyi.lisans, "Makine", 88, 55);

            //a.NotHesapla();
            //m.NotHesapla(m.Not1,m.Not2);

            //m.NotHesapla();

            OgrenciNotHesapla(m);
            OgrenciNotHesapla(a);

            Console.ReadLine();

        }
        static void OgrenciNotHesapla(Ogrenci ogr)
        {
            ogr.NotHesapla();
        }
    }
}
