// Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков
// длины B (без наложений). Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.

using System;

namespace ConsoleApp
{
    class Programm
    {
        //очищен код программы от лишних действий, оптимизация вывода данных через знак $
        static void Main(string[] argh)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //решение проблем с выводом русского языка в консоль
            Console.Write("A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"В отрезке A содержится {a / b} полных отрезков B.");
            Console.ReadKey();            
        }
    }
}