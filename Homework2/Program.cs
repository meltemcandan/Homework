using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotEverage();
        }

        public static void NotEverage()
        {
            double vize, final, sonuc;
            Console.Write("Vize Notunuzu Giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notunuzu Giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            sonuc = vize * 0.4 + final * 0.6;
            if (sonuc > 60)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Console.ReadLine();
        }
    }
}
