// . Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму

using System;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] argh)
        {
            double A, B, C, AC, BC, sum;
            Console.Write("A = ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C = ");
            C = Convert.ToDouble(Console.ReadLine());
            AC = Math.Abs(C - A);
            BC = Math.Abs(C - B);
            sum = AC + BC;
            Console.Write($"AC = {AC}, BC = {BC}, sum = {sum}");
            Console.ReadKey();





        }
    }
}    