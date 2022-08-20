using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_HW
{
    internal class Ticari : Arac
    {
        public int TasimaKapasitesi;
        public int YolcuKapasitesi;

        public Ticari()
        {
            marka = MARKALAR.Mercedes;
            vites = VITES.Otomatik;
            renk = RENK.Mor;
            motorHacmi = 1500;
            Ceker4 = true;
            TasimaKapasitesi = 500;
            YolcuKapasitesi = 10;

        }

        public void TicariBilgiYaz()
        {
            Console.WriteLine("Araç Bilgileri:\n{0} {1} {2} {3} {4} {5} {6}", marka, vites, renk, motorHacmi, Ceker4, TasimaKapasitesi, YolcuKapasitesi);
        }
    }
}
