//  Даны стороны прямоугольника a и b. Найти его площадь S = a·b и периметр P = 2·(a + b).

using System;

namespace ConsolApp
{
    class Proramm
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double S = a * b;
            double P = 2 * (a + b);
            Console.WriteLine("P = " + P);
            Console.WriteLine("S = " + S);
            Console.ReadKey();
        }




    }
}