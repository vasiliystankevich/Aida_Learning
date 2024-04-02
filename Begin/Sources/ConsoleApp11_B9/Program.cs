//  Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b.

 using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            ulong sum;
            Console.Write("a = ");
            ulong a = Convert.ToUInt64(Console.ReadLine());
            Console.Write("b = ");
            ulong b = Convert.ToUInt64(Console.ReadLine());
            sum = a * b;
            var ga = Math.Sqrt(sum);
            Console.Write("ga = " + ga);
            Console.ReadKey();
        }
    }
}