// Дана площадь S круга. Найти его диаметр D и длину L окружности, ограничивающей этот круг, учитывая,
// что L = 2·π·R, S = π·R2. В качестве значения π использовать 3.14.

using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            Console.Write("S = ");
            double S = Convert.ToDouble(Console.ReadLine());
            double p = 3.14;
            double R = Math.Sqrt((S / p));
            double L = 2 * p * R;
            double D = 2 * R;
            Console.WriteLine($"D = {D}, L = {L}");
            Console.ReadKey();
        }
    }
}