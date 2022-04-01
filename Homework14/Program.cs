using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DonenDeger = toplamaYap (6, 7);
            Console.WriteLine(DonenDeger);
            Console.ReadLine();
            
        }
        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;

            return sonuc;

        }
    }
}
