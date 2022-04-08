using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elemanları kullanıcı tarafından girilen 10 elemanlı string bir dizide, en uzun metni, en uzun metnin karakter sayısını ve en uzun metnin index numarasını bulan ve ekrana yazdıran Console Örneği:

            int uzunluk = 0;
            string enUzunMetin = "";
            int indexNo = 0;

            string[] dizi = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Dizinin {0}. elemanı giriniz : ", i + 1);
                dizi[i] = Console.ReadLine();
            }


            for (int i = 0; i < 10; i++)
            {
                if (dizi[i].Length > uzunluk)
                {
                    uzunluk = dizi[i].Length;
                    enUzunMetin = dizi[i];
                    indexNo = i;
                }
            }

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine("Dizi içindeki en uzun metin: {0}", enUzunMetin);
            Console.WriteLine("Dizi içindeki en uzun metnin index numarası : {0}", indexNo);
            Console.WriteLine("Dizi içindeki en uzun metnin karakter sayısı: {0}", uzunluk);
            Console.ReadKey();
        }
    }
}
