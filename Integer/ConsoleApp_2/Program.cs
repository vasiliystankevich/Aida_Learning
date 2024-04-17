// Дана масса M в килограммах. Используя операцию деления нацело,
// найти количество полных тонн в ней (1 тонна = 1000 кг). не понимаю почему не работает

using System;

namespace ConsoleApp_2
{
    class Program
    {
        static void Main(string[] argh) //была обнаружена лишняя точка с запятой, исправленно
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //решение проблем с выводом русского языка в консоль
            Console.Write("M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int Mt = M / 1000;
            Console.Write("Mt: " + Mt);
            Console.ReadKey();
        }
    }
}