using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_HW_2
{
    internal class Lise : Ogrenci
    {
       
        public int Not1;
        public int Not2;

        public Lise(string AdSoyad, int OkulNo, string OkulAdi, Ogretim_Duzeyi Ogretim, int Not1, int Not2) : base(AdSoyad, OkulNo, OkulAdi, Ogretim)        {
           
            this.Not1 = Not1;
            this.Not2 = Not2;
        }

        public void NotHesapla(int Not1, int Not2)
        {
           if(Not1>=0 && Not1<101 && Not2>-1 && Not2 < 101)
            {
                int ortalama = (Not1 + Not2) / 2;
                Console.WriteLine("Not Ortalaması:{0}", ortalama);

                if (100 >= ortalama && ortalama > 85)
                {
                    Console.WriteLine("Pekiyi");
                }
                else if (ortalama > 70)
                {
                    Console.WriteLine("İyi");
                }
                else if (ortalama > 60)
                {
                    Console.WriteLine("Orta");
                }
                else if (ortalama > 50)
                {
                    Console.WriteLine("Geçer");
                }
                else if (ortalama > 0)
                {
                    Console.WriteLine("Tekrar");
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

        public override void NotHesapla()
        {
            if (this.Not1 >= 0 && this.Not1 < 101 && this.Not2 > -1 && this.Not2 < 101)
            {
                int ortalama = (Not1 + Not2) / 2;
                Console.WriteLine("Not Ortalaması:{0}", ortalama);

                if (100 >= ortalama && ortalama > 85)
                {
                    Console.WriteLine("Pekiyi");
                }
                else if (ortalama > 70)
                {
                    Console.WriteLine("İyi");
                }
                else if (ortalama > 60)
                {
                    Console.WriteLine("Orta");
                }
                else if (ortalama > 50)
                {
                    Console.WriteLine("Geçer");
                }
                else if (ortalama > 0)
                {
                    Console.WriteLine("Tekrar");
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
