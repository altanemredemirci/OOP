using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance
{
    internal class Program
    {
        /*
         Inheritance: Ortak özelliklere sahiip classların ortal properties base(temel) bir class altında toplamamızı ve bu ortak özellikleri kalıtım(miras) alma yöntemi ile aktarma işlemidir.
        Amaç ortak olan özellikleri her class için tekrar tekrar yazmaktan ve gerekli durumlarda yeni bir ortak özellik ekleme kolaylığı sağlar.

        *** HER CLASS TEK(SINGLE) INHERITANCE ALABİLİR.
         */
        static void Main(string[] args)
        {
            //List<Kedi> kedis = new List<Kedi>();
            //List<Kopek> kopeks = new List<Kopek>();

            //Kedi k = new Kedi();
            //kedis.Add(k);
            //Kopek kk = new Kopek();
            //kopeks.Add(kk);


            Balina b = new Balina();
            Console.ReadLine();
            /*
             ETICARET
            kitap
            etek
            tshirt
            kazak
            oyun
            ..
            ...

            ..
            40 * 3 => 120
             */



        }
    }

    class Memeli
    {
        public string Ad { get; set; }
        public double Agirlik { get; set; }
        public double Boy { get; set; }
        public int Yas { get; set; }

        public Memeli()
        {
            Console.WriteLine("Bu bir Memeli Constructor Method");
        }

        public void Yaz()
        {
            Console.WriteLine("Ad:"+Ad);
        }
    }

    class Kedi:Memeli
    {      
        public string Cins { get; set; }
    }

    class Kopek:Memeli
    {       
        public string Tur { get; set; }
    }
    class Koyun:Memeli
    {       
        public int Yas { get; set; }
    }
    class Balina:Memeli
    {     
        public int YuzgecSayisi { get; set; }
    }
}
