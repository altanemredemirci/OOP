using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    internal class Ogretmen:BaseEntity
    {
        public string Brans { get; set; }
        public new void Register()
        {
            base.Register();
            Console.WriteLine("Branş:");
            Brans = Console.ReadLine();
        }
    }
}
