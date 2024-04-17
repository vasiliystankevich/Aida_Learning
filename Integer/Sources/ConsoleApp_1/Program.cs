// Дано расстояние L в сантиметрах. Используя операцию делениянацело, найти
// количество полных метров в нем (1 метр = 100 см)

using System;

namespace ConsoleApp_1
{
    class Programm
    {
        static void Main(string[] argh)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8; //решение проблем с выводом русского языка в консоль
            int L, Lm; //почему нельзя это написать? //двойное обьявление переменной запрещенно, строки 14 и 15
            Console.Write("L: ");
            L = int.Parse(Console.ReadLine());
            Lm = L / 100;
            Console.WriteLine("Lm:" + Lm);
            Console.ReadKey();
        }
    }
}