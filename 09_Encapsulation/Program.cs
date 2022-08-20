using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            Console.WriteLine("Başında TR olacak şekilde IBAN:");
            c._IBAN = Console.ReadLine().ToUpper();
            Console.WriteLine(c._IBAN);
            Console.ReadLine();
        }
    }
    class Customer
    {
        public string Name;
        public string Surname;
        private string IBAN;

        public string _IBAN {
            get { return IBAN; } 
            set 
            {
                if (value.StartsWith("TR") && value.Length == 10) //value.Substring(2)
                {
                    this.IBAN = value;
                }
                else
                {
                    while(!value.StartsWith("TR") || value.Length != 10)
                    {
                        Console.WriteLine("IBAN:");
                        value = Console.ReadLine().ToUpper();
                    }
                    this.IBAN = value;
                }

            } 
        }
    }
}
