// Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P: c =√aст2 + bст2
// P = a + b + c

using System;

namespace ConsoleApp
{
    class programm
    {
        static void Main(string[] argh)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2)) + Math.Sqrt(Math.Pow(b, 2));
            double P = a + b + c;
            Console.WriteLine($"c = {c}, P = {P}");
            Console.ReadKey();
        }
    }
}