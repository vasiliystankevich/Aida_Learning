// Найти длину окружности L и площадь круга S заданного радиуса R: L = 2·π·R, S = π·Rст2;

using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            double L, S;
            double p = 3.14;
            Console.Write("R = ");
            double R = Convert.ToDouble(Console.ReadLine());
            L = 2 * p * R;
            Console.WriteLine("L = " + L);
            S = p * Math.Pow(R, 2);
            Console.WriteLine("S = " + S);
            Console.ReadKey();
            
        }
    }
}