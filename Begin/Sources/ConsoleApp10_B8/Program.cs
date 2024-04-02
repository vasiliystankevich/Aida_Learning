
//  Даны два числа a и b. Найти их среднее арифметическое: (a + b)/2.

using System;

namespace ConsoleApp
{
    class Proramm
    {
        static void Main(string[] argh)
        {
            double average;
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            average = (a + b) / 2;
            Console.WriteLine("average = " + average);
            Console.ReadKey();
        }
    }
}