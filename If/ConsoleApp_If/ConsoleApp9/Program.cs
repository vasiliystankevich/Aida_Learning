// Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так,
// чтобы в A оказалось меньшее из значений, а в B — большее. Вывести новые значения переменных A и B

using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите две переменные вещественного типа: ");
            var arr = Console.ReadLine().Split();
            var a = Convert.ToDouble(arr[0]);
            var b = Convert.ToDouble(arr[1]);
            if (a > b)
            {
                Console.WriteLine($"От меньшего к большему: А = {b}, В = {a}");
            }
            else
            {
                Console.WriteLine($"От меньшего к большему: А = {a}, В = {b}");
            }

            Console.ReadKey();

        }
    }
}