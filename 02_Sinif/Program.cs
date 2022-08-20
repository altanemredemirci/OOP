using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Personel kayıt => Ad,Soyad,Yas,TC


            List<Personel> personels = new List<Personel>();

            Personel p = new Personel();
            p.ad = "Tarık";
            p.soyad = "Hamarat";
            p.tc = "1223213213";
            personels.Add(p);
            

            Personel p2 = new Personel();
            p2.ad = "Tarık";
            p2.soyad = "Hamarat";
            p2.yas = 25;
            p2.tc = "998878877";


            personels.Add(p);
            personels.Add(p2);


            foreach (Personel item in personels)
            {
                if (item.ad == "Tarık")
                {
                    Console.WriteLine(item.ad+item.soyad);
                }
            }

            Console.ReadLine();
        }
    }

    class Personel
    {
        public string ad;
        public string soyad;
        public int yas;
        public string tc;
    }

    
}
