using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    internal class BaseEntity
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
        public string Adres { get; set; }

        public void Register()
        {
            Console.WriteLine("Ad:");
            Isim = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyisim = Console.ReadLine();
            Console.WriteLine("Adres:");
            Adres = Console.ReadLine();
            Console.WriteLine("Yaş:");
            Yas = Convert.ToInt32(Console.ReadLine());           
        }
    }
}
