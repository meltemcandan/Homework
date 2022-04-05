using System;

namespace Homework22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen bir cümledeki kelime sayısını bulunuz
            Console.WriteLine("Lütfen bir cümle yazınız: ");
            string cümle= Console.ReadLine();
            string[] kelimeler = cümle.Split(' ');
            Console.WriteLine(kelimeler.Length);
            Console.ReadLine();
        }
    }
}
