using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            ArrayList sayilarArray = new ArrayList();

            List<int> sayilarList = new List<int>();
            sayilarList.Add(56);
            sayilarList.Add(11);
            sayilarList.Add(21);
            sayilarList.Add(12);
            sayilarList.Add(13);
            sayilarList.Add(14);
            sayilarList.Add(15);
            sayilarList.Add(16);
            sayilarList.Add(17);
            sayilarList.Add(18);

            //foreach (int item in sayilarList)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("------------------");

           

            Console.WriteLine("-------- LIST METHODS ---------");


            //foreach (int item in sayilarList)
            //{
            //    Console.WriteLine(item);
            //}

           

            //Koşul Tanımlama
            List<int> yeniSayilar = new List<int>();

            foreach (int item in sayilarList)
            {
                if (item > 14)
                {
                    yeniSayilar.Add(item);
                    Console.WriteLine(item);
                }
            }

            

            


            Console.ReadLine();
        }
    }
}
