using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Abstract
{
    enum Markalar : byte { Honda = 1, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo }
    enum Vitesler : byte { Manuel, Otomatik, Yarı_Otomatik }
    enum Renkler : byte { Kırmızı, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor }

    //Arac Sınıfı
    abstract class Arac
    {
        public Markalar Marka; // Enumdan değişken tanımlama
        public Vitesler Vites;
        public Renkler Renk;
        protected short MotorHacmi;
        // Mainde direkt atama yapılamaz ancak yapıcı metot ile değer ataması yapılabilir.

        //Arac Sınıfı Constructer(Yapıcı) Metotu
        public Arac(Markalar marka, Vitesler vites, Renkler renk, short motorHacmi)
        {
            Marka = marka; Vites = vites; Renk = renk; MotorHacmi = motorHacmi;
            //Yanyana olması birşey farkettirmez.Noktalı virgülle ayrılır.
        }

        public  void Oku()
        {
            Console.WriteLine("sadasdsdad");
        }

        public abstract void Yaz();

    }
    //Otomobil Sınıfı
    class Otomobil : Arac
    {
        public byte KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        //Otomobil Sınıfı Constructer(Yapıcı) Metotu
        // Arac sınıfına ait yapıcı parametrelerini de alır
        // : base() terimiy ile ana sınıfta çalıştırılmak üzere ana sınıfa gönderir
        public Otomobil(byte kapiSayisi, string model, bool ceker4, bool parksensoru, Markalar marka, Vitesler vites, Renkler renk, short motorHacmi) : base(marka, vites, renk, motorHacmi)
        {
            this.KapiSayisi = kapiSayisi;
            this.Model = model;
            this.Ceker4 = ceker4;
            this.ParkSensoru = parksensoru;
        }

        public void OtomobilBilgiYaz()
        {
            /*Ekrana yazdırırken bool tipindeki değişkenlere karşılık string ifadeler
             * yazdırmak için 2 adet string tanımladık.
             */
            string sCeker4;
            if (Ceker4 == true)
                sCeker4 = "Araç 4 Çeker";
            else
                sCeker4 = "Araç 2 Çeker";

            string sParkSensoru;
            if (ParkSensoru == true)
                sParkSensoru = "Var";
            else
                sParkSensoru = "Yok";

            Console.WriteLine($"Araç Markası: {Marka}  Modeli: {Model}");
            Console.WriteLine($"Araç Vites Tipi: {Vites}  Rengi: {Renk}");
            Console.WriteLine($"Araç Motor Hacmi: {MotorHacmi}  Kapı Sayısı: {KapiSayisi}");
            Console.WriteLine(sCeker4);
            Console.WriteLine($"Park Sensörü {sParkSensoru}");
        }

        public override void Yaz()
        {
            throw new NotImplementedException();
        }
    }
    class Ticari : Arac
    {
        public short TasimaKapasitesi;
        public short YolcuKapasitesi;
        public bool Ceker4;

        public Ticari(short tasimaKapasitesi, short yolcuKapasitesi, bool ceker4, Markalar marka, Vitesler vites, Renkler renk, short motorHacmi) : base(marka, vites, renk, motorHacmi)
        {
            this.TasimaKapasitesi = tasimaKapasitesi;
            this.YolcuKapasitesi = yolcuKapasitesi;
            this.Ceker4 = ceker4;
        }
        public void TicariBilgiYaz()
        {
            /*Ekrana yazdırırken bool tipindeki değişkenlere karşılık string ifadeler
             * yazdırmak için 2 adet string tanımladık.
             */
            string sCeker4;
            if (Ceker4 == true)
                sCeker4 = "Araç 4 Çeker";
            else
                sCeker4 = "Araç 2 Çeker";

            Console.WriteLine($"Araç Markası: {Marka} Taşıma Kapasitesi: {TasimaKapasitesi}");
            Console.WriteLine($"Araç Vites Tipi: {Vites}  Rengi: {Renk}");
            Console.WriteLine($"Araç Motor Hacmi: {MotorHacmi}  Yolcu Kapasitesi: {YolcuKapasitesi}");
            Console.WriteLine(sCeker4);
        }

    }
    class Program
    {
        /*ABSTRACT NEDİR?*/
        /*Abstract class’lar, oluşturulması istenen class’ların sadece base class olarak davranması
         * ve üzerinden bir instance oluşturulmamasının istendiği durumlarda kullanılır. 
         * C#’da bu fonksiyonaliteyi sağlamak için abstract anahtar sözcüğünü kullanmak yeterlidir. */
        static void Main(string[] args)
        {

            Arac arac = new Arac(Markalar.Scania, Vitesler.Otomatik, Renkler.Mor,1500);


            Otomobil benimArabam = new Otomobil(2, "Practica", false, false, Markalar.Mazda, Vitesler.Otomatik, Renkler.Yeşil, 1500);
            benimArabam.OtomobilBilgiYaz();

            Console.WriteLine("\n***\n");
            Ticari benimTicarim = new Ticari(1500, 2, true, Markalar.Volvo, Vitesler.Manuel, Renkler.Kırmızı, 4500);
            benimTicarim.TicariBilgiYaz();

            Console.ReadKey();
        }
    }
}
