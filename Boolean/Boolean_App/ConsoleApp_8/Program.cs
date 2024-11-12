// Даны два целых числа: A, B. Проверить истинность высказывания:«Каждое из чисел A и B нечетное».

using System;

namespace ConsoleApp_8
{
    class Program
    {
        static void Main(string[] argh)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите два целых числа: ");
            string[] arr = Console.ReadLine().Split();
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            bool ac = (a % 2 != 0);
            bool bc = (b % 2 != 0);
            if (ac == bc)
            {
                Console.WriteLine("Оба числа нечетные");
            }
            else
            {
                Console.WriteLine("Высказывание 'Каждое из чисел А и В нечетное' - ложно");
            }

            Console.ReadKey();

        }
    }
}