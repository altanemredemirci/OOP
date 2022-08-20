using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Enum
{
    //ENUM: Veri tipi tanımlama işlemidir.

    enum GUNLER : byte
    {
        PAZARTESI,
        SALI,
        CARSAMBA,
        PERSEMBE,
        CUMA,
        CUMARTESI,
        PAZAR
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hafta h = new Hafta();
            h.Sayisi = 2;
            h.gun = GUNLER.SALI;

        }
    }
    class Hafta
    {
        public int Sayisi { get; set; }
        public GUNLER gun { get; set; }
    }
}
