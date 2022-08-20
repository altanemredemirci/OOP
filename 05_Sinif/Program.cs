using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Personel: ad,soyad,tc
            // Kayıt ve Giriş Methodları kodlayınız. 

            List<Personel> personels = new List<Personel>();

            while (true)
            {
                Console.WriteLine("1-Register\n2-Login\n3-Quit\nProcess:");
                string proc = Console.ReadLine();
                if (proc == "1")
                {
                    Personel.Register(personels);
                }
                else if (proc == "2")
                {
                   Personel.Login(personels);

                    Personel pp = new Personel();
                    pp=Personel.LoginReturn(personels);
                    Console.WriteLine("Giriş Başarılı");
                    Console.WriteLine("Hoşgeldiniz Sayın:" + pp.Ad + " " + pp.Soyad);
                }
                else
                {
                    break;
                }
            }

          

        }
    }

    class Personel 
    {
        //property default olarak PRIVATE(GİZLİ) tanımlıdır.
        public string Ad;
        public string Soyad;
        public string TC;

        public static void Register(List<Personel> liste)
        {
            Personel p = new Personel();

            Console.WriteLine("Ad:");
            p.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            p.Soyad = Console.ReadLine();
            Console.WriteLine("TC:");
            p.TC = Console.ReadLine();
            liste.Add(p);
        }

        public static void Login(List<Personel> personels)
        {
            Console.WriteLine("TC:");
            string tc = Console.ReadLine();

            foreach (Personel p in personels)
            {
                if (p.TC == tc)
                {
                    Console.WriteLine("Giriş Başarılı");
                    Console.WriteLine("Hoşgeldiniz Sayın:" + p.Ad + " " + p.Soyad);
                    break;
                }
            }
        }

        public static Personel LoginReturn(List<Personel> personels)
        {
            Console.WriteLine("TC:");
            string tc = Console.ReadLine();

            foreach (Personel p in personels)
            {
                if (p.TC == tc)
                {
                    return p;
                }
            }
            return null;
        }
    }
}