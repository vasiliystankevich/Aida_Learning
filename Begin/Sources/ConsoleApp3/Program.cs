// See https://aka.ms/new-console-template for more information

// 1.Дана сторона квадрата a. Найти его периметр P = 4·a.

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
            double P = 4 * a;
            Console.WriteLine("P:" + P);
            Console.ReadKey();
        }
    }
}