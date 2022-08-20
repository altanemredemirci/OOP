using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Sinif_This
{
    internal class User
    {
        public string Name;
        public string Surname;


        //Nonstatic = 
        public void Register()
        {
            Console.WriteLine("Name:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            this.Surname = Console.ReadLine();
        }

        public void Register(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
