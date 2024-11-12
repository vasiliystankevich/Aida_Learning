//  Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное
// количество отрезков длины B (без наложений). Используя операцию взятия остатка от деления нацело, найти
// длину незанятой части отрезка A.

using System;

namespace ConsoleApp_5
{
    class Programm
    {
        static void Main(string[] argh)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            int result;
            int c = Math.DivRem(a, b, out result);
            Console.WriteLine("result = " + result);
            //int c = a % b;
            //Console.WriteLine("result = " + c);
            Console.ReadKey();

        }
    }
}    