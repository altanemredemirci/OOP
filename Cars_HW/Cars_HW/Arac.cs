using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_HW
{
    enum MARKALAR : byte
    {
        Honda, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo
    }
    enum VITES : byte
    {
        Manuel, Otomatik, Yarı_Otomatik
    }
    enum RENK  
    {
        Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor
    }

    internal class Arac
    {
        public MARKALAR marka;
        public VITES vites;
        public RENK renk;
        public int motorHacmi;
        public bool Ceker4;
     
    }
}
