// Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти
// его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c)

using System;

namespace ConsoleApp
{
    class Proramm
    {
        static void Main(string[] argh)
        {
            double V, S;
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            V = a * b * c;
            Console.WriteLine("V = " + V);

            S = 2 * (a * b + b * c + a * c);
            Console.WriteLine("S = " + S);
            Console.ReadKey();
            

        }
    }
}