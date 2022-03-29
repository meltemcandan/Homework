using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 100' den 0'a kadar olan çift sayıları yazdırma örneği
            int sayi = 100;
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                sayi -= 2;
            }
            Console.ReadLine();
        }
    }
}
