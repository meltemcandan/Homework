using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İç içe for döngüsü kullanım örneği
            int sayi = 10;
            for (int i = 1; i <= sayi; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
