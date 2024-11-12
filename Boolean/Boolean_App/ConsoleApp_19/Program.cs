// Проверить истинность высказывания: «Среди трех данных целых
// чисел есть хотя бы одна пара взаимно противоположных».

using System;

namespace ConsoleApp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите последовательно три целых числа: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            int aa = Math.Abs(a);
            int bb = Math.Abs(b);
            int cc = Math.Abs(c);
            if ((aa == bb) || (aa == cc) || (bb == cc))
                Console.WriteLine("Среди трех данных целых чисел есть хотя бы одна пара взаимно противоположных");
            else
            {
                Console.WriteLine("Среди трех данных целых чисел нет взаимно противоположных");
            }

            Console.ReadKey();
            // скорее всего решение неверное, т.к. если ввести два одинаковых числа программа все равно выдаст верный ответ

        }
    }
}
