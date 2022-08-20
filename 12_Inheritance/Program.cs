using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Miras olarak alınan bir field(property,method) türeyen sınıfta tekrar yazılmamalıdır. Eğer yazılma amaçı revize etmek ise revize edilecek field'ın başına NEW keyword yazılmalıdır.
             Türeyen sınıf içerisinde miras alınan sınıfa erişilmek istenilirse BASE adı verilen keyword kullanılmalıdır.
             */


            //List<Ogrenci> ogrenciList = new List<Ogrenci>();

            //Ogrenci o = new Ogrenci();
            //o.Register();

            //ogrenciList.Add(o);


            List<Ogretmen> ogretmenList = new List<Ogretmen>();

            Ogretmen ogr = new Ogretmen();
            ogr.Register();

            ogretmenList.Add(ogr);
        }
    }
    
}
