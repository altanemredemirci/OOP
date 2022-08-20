using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Bilgisayar
    {
        public string Marka;
        public string CPU;
        public string RAM;

        public virtual void OzellikYazdir()
        {
            Console.WriteLine("Marka: {0}\nİşlemci: {1}\nRAM: {2}", Marka, CPU, RAM);
        }
    }
    class Notebook : Bilgisayar
    {
        public string bluetooth;


        public override void OzellikYazdir()
        {

            Console.WriteLine("Marka: {0}\nİşlemci: {1}\nRAM: {2}\nBluetooth: {3}", Marka, CPU, RAM, bluetooth);
        }

    }
}
