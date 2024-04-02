//  Дана сторона квадрата a. Найти его площадь S = a

using System;

namespace ConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.Write("a:");
            a = Convert.ToDouble(Console.ReadLine());
            double S = a * a;
            Console.WriteLine("S:" + S);
        }
    }
}    
        