using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan 10 tane sayıyı biz dizi içine atayarak küçükten büyüğe sıralama

            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Dizinin " + (i+0)+ ". index değerini giriniz");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();

        }
    }
}
