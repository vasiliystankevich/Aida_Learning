// Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.

using System;

namespace ConsoleApp
{
    class programm
    {
        static void Main(string[] argh)
        {
            // int sum, dif, prod, quot;
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            double sum = Math.Pow(a, 2) + Math.Pow(b, 2);
            double dif = Math.Pow(a, 2) - Math.Pow(b, 2);
            double prod = Math.Pow(a, 2) * Math.Pow(b, 2);
            double quot = Math.Pow(a, 2) / Math.Pow(b, 2);
            
            Console.WriteLine($"sum = {sum}, dif = {dif}, prod = {prod}, quot = {quot} " );
            Console.ReadKey();
            


        }
    }
}