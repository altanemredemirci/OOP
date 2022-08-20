using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil o = new Otomobil();
            o.OtomobilBilgiYaz();

            Ticari t = new Ticari();
            t.TicariBilgiYaz();

            Console.ReadLine();

        }
    }
}
