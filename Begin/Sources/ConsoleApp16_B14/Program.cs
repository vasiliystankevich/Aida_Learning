//  Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью, учитывая, что L = 2·π·R,
// S = π·R2. В качестве значения π использовать 3.14.

using System;

namespace ConsoleApp
{
    class programm
    {
        static void Main(string[] argh)
        {
            Console.Write("L = ");
            double L = Convert.ToDouble(Console.ReadLine());
            double p = 3.14;
            double R = L / 2 * p;
            double S = p * Math.Pow(R, 2);
            Console.WriteLine($"R = {R}, S = {S}");
            Console.ReadKey();
        }
    }
}