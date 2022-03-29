using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--*'larla Dik Üçgen Uygulaması--

            for (int i = 1; i <= 10; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
