using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Elemanları kullanıcı tarafından dışarıdan girilen 10 elemanlı bir dizinin elemanlarını % 10 arttıran ve ekrana yazdıran örnek:
            
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Dizinin {0}. elemanını giriniz:", i+1);
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < 10; i++)
            {
                dizi[i] += (dizi[i] * 10 / 100);
                Console.WriteLine(" Dizinin {0}. indexi : {1} ",i , dizi[i]);
               
            }
            Console.ReadLine();
        
        }
    }
}
