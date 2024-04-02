//  Дан диаметр окружности d. Найти ее длину L = π·d. В качестве значения π использовать 3.14

using System;

namespace ConsoleApp
{
    class Proramm
    {
        static void Main(string[] args)
        {
            double L, d;
            double p = 3.14;
            Console.Write("d = ");
            d = Convert.ToDouble(Console.ReadLine());
            L = p * d;
            Console.WriteLine("L = " + L);
            Console.ReadKey();

        }
    }
}


