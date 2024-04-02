// Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2 − x1|

using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Math.Abs(x2 - x1);
            Console.WriteLine("x3: " + x3);
            Console.ReadKey();
            
        }
    }
}