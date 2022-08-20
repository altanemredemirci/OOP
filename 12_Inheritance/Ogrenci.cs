using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    internal class Ogrenci:BaseEntity
    {
        public string Bolum { get; set; }

        public new void Register()
        {
            base.Register();
            Console.WriteLine("Bolum:");
            Bolum = Console.ReadLine();           
        }
    }

    
}
