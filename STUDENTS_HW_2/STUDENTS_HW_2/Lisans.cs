using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_HW_2
{
    internal class Lisans : Ogrenci
    {
        public string Fakulte;
        public int VizeNotu;
        public int FinalNotu;

        public Lisans(string AdSoyad, int OkulNo, string OkulAdi, Ogretim_Duzeyi Ogretim, string Fakulte, int VizeNotu, int FinalNotu) : base(AdSoyad, OkulNo, OkulAdi, Ogretim)
        {
            this.Fakulte = Fakulte;
            this.VizeNotu = VizeNotu;
            this.FinalNotu = FinalNotu;
        }

        public override void NotHesapla()
        {
            if(VizeNotu>-1 && VizeNotu<101 && FinalNotu>-1 && FinalNotu < 101)
            {
                double ortalama = ((VizeNotu * 0.4) + (FinalNotu * 0.6));
                Console.WriteLine("Not Ortalaması:{0}", ortalama);

                if (100 >= ortalama && ortalama > 85)
                {
                    Console.WriteLine("A");
                }
                else if (ortalama > 70)
                {
                    Console.WriteLine("B");
                }
                else if (ortalama > 60)
                {
                    Console.WriteLine("C");
                }
                else if (ortalama > 50)
                {
                    Console.WriteLine("D");
                }
                else if (ortalama > 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("Hatalı Not Girişi!!!");
                }
            }
            else
            {
                base.NotHesapla();
            }
        
        }
    }
}
