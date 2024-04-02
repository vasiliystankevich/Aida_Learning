// Дана длина ребра куба a. Найти объем куба V = aст3 и площадь его поверхности S = 6·aст2
    
using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            double V, S, exponent2, exponent3;
            double ex = 2;
            double exp = 3;
            double a;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            
            V = Math.Pow(a, exp);
            S = 6 * Math.Pow(a, ex);
            Console.WriteLine("V = " + V);
            Console.WriteLine("S = " + S);
            Console.ReadKey();

        }
    }
}
