// Даны два целых числа: A, B. Проверить истинность высказывания: «Хотя бы одно из чисел A и B нечетное»

using System;

namespace ConsoleApp_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите два целых числа А и В: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            bool c = ((a % 2) != 0) | ((b % 2) != 0);
            Console.Write("Высказывание 'Хотя бы одно из чисел А и В нечетное' - {0}", c);
            Console.ReadKey();
            
        }
    }
}