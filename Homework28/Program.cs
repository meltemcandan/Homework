using System;

namespace Homework28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen string ifadede “,” karakterlerini “.” karakteri olarak değiştiren program

            
            Console.Write("Metni Giriniz : ");
            string metin = Console.ReadLine();
            string yenimetin = metin.Replace(',', '.');
            Console.WriteLine(yenimetin);
            Console.ReadLine();

        }
    }
}
