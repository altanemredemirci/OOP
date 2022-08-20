using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sinif_LoginRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uyelik Sistemi

            List<User> userList = new List<User>();
            while (true)
            {
                Console.WriteLine("1-Login\n2-Register\nSeçim:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    User.Login(userList);
                }
                else if (secim == 2)
                {
                   userList.Add(User.Register());
                }
                else
                {
                    Console.WriteLine("Hatalı seçim!!");
                }
            }
        }
    }

    class User
    {
        public string username;
        public string password;
        public string email;
        public string name;
        public string surname;

        public static User Register()
        {
            User user = new User();
            Console.WriteLine("Name:");
            user.name = Console.ReadLine();

            Console.WriteLine("Surname:");
            user.surname = Console.ReadLine();

            Console.WriteLine("Username:");
            user.username = Console.ReadLine();

            Console.WriteLine("Password:");
            user.password = Console.ReadLine();

            Console.WriteLine("Email:");
            user.email = Console.ReadLine();

            return user;
        }

        public static void Login(List<User> liste)
        {
            Console.WriteLine("Username:");
            string KullaniciAdi = Console.ReadLine();

            Console.WriteLine("Password:");
            string Sifre = Console.ReadLine();

            foreach (User u in liste)
            {
                if (u.username == KullaniciAdi && u.password == Sifre)
                {
                    Console.WriteLine("Giriş Başarılı!!");
                }
            }
        }
    }
}
