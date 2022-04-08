using System;

namespace Homework29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen String ifadede boşluk karakterine kadar olan kısmı yazdıran program
            string metin;
            Console.Write("Metni Giriniz : ");
            metin = Console.ReadLine();
            int no = metin.IndexOf(' ');
            Console.WriteLine(metin.Substring(0, no));
            Console.ReadLine();

        }



    }
    
}
