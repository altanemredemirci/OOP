using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Encapsulation
{
    internal class Program
    {
        /* ******** OOP TEMELLERİ *********
         * Encapsulation - Kapsülleme
         * Inheritance - Kalıtım
         * Polymorphism - Çok Biçimlilik
         * Abstraction - Soyutlama   
         */
        static void Main(string[] args)
        {
            // ENCAPSULATION

            Customer c = new Customer();
            c.Name = "Elmander";
            c.Surname = "De Souza";
            c._TC = "12345"; // 11 haneli.
            Console.WriteLine(c._TC);
        }
    }

    class Customer
    {
        public string Name;
        public string Surname;
        private string TC;

        //get: readonly özelliğe sahiptir ve private değeri döndürür.
        //set: girilen value ifadesini kontrollerden geçirmeyi ve şartlar sağlanıyor ise private property set etmeyi sağlar.
        public string _TC
        {
            get { return TC; }
            set
            {
                if (value.Length == 11)
                {
                    TC = value;
                }
                else
                {
                    TC = "000000000000";
                    Console.WriteLine("Hatalı TC girişi!!!");
                }
            }
        }
    }
}
