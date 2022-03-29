using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çarpım tablosu örneği
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                }
            }
            Console.ReadLine();
        }
    }
}
