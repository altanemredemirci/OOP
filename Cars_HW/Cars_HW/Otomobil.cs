using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_HW
{
    internal class Otomobil : Arac
    {
        public int KapiSayisi;
        public string Model;
        public bool ParkSensoru;

        public Otomobil()
        {
            marka = MARKALAR.Honda;
            vites = VITES.Manuel;
            renk = RENK.Beyaz;
            motorHacmi = 1500;
            Ceker4 = true;
            KapiSayisi = 4;
            Model = "CR-V";
            ParkSensoru = true;
        }
        public void OtomobilBilgiYaz()
        {
            Console.WriteLine("Araç Bilgileri:\n{0} {1} {2} {3} {4} {5} {6} {7}", marka, vites, renk, motorHacmi, Ceker4, KapiSayisi, Model, ParkSensoru);
        }
    }
}
