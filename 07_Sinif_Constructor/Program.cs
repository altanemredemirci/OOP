using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sinif_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AD:");
            string ad = Console.ReadLine();
            Console.WriteLine("SOYAD:");
            string soyad = Console.ReadLine();
           
            User u = new User(ad,soyad);

            User u2 = new User();

            Console.ReadLine();
        }
    }

    class User
    {
        // CONSTRUCTOR METHOD:
        // * Instance alındığı zaman çalışan bir methoddur.
        // * Default olarak boş bir şekilde gizli yapıda tanımlıdır. 
        // * Class ile aynı isimdedir. Herhangi bir void veya return ifade almaz.

        public string Name;
        public string Surname;



        //public User()
        //{
        //    Console.WriteLine("Constructor Method Çalıştı...");
        //    Console.WriteLine("Name:");
        //    this.Name = Console.ReadLine();
        //    Console.WriteLine("Surname:");
        //    this.Surname = Console.ReadLine();
        //    Console.WriteLine("Ad:"+this.Name+" Soyad:"+this.Surname);
        //}

        //public User()
        //{
        //    this.Register();
        //}

        public User()
        {
            this.Register();
        }

        public User(string ad,string soyad)
        {
            this.Name = ad;
            this.Surname = soyad;
        }

        public void Register()
        {
            Console.WriteLine("Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            this.Surname = Console.ReadLine();
        }
    }
}
