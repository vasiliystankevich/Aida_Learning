//  Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.

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
            
            double sum = Math.Abs(a) + Math.Abs(b);
            double dif = Math.Abs(a) - Math.Abs(b);
            double prod = Math.Abs(a) * Math.Abs(b);
            double quot = Math.Abs(a) / Math.Abs(b);
            
            Console.WriteLine($"sum = {sum}, dif = {dif}, prod = {prod}, quot = {quot} " );
            Console.ReadKey();

        }
    }
}